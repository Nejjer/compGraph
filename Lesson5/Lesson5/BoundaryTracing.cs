using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace Lesson5
{
class BoundaryTracing
    {
        // This gets all boundaries in the given pixels.
        // It assumes you're looking for boundaries between non-transparent shapes on a transparent background
        // (using the isTransparent property);
        // but you could modify this, to pass in a predicate to say what background color you're looking for (e.g. White).
        static List<List<Point>> create(Pixels pixels)
        {
            Size size = pixels.size;
            HashSet<Point> found = new HashSet<Point>();
            List<Point> list = null;
            List<List<Point>> lists = new List<List<Point>>();
            bool inside = false;

            // Defines the neighborhood offset position from current position and the neighborhood
            // position we want to check next if we find a new border at checkLocationNr.
            int width = size.Width;
            Tuple<Func<Point, Point>, int>[] neighborhood = new Tuple<Func<Point, Point>, int>[]
            {
                new Tuple<Func<Point, Point>, int>(point => new Point(point.X-1,point.Y), 7),
                new Tuple<Func<Point, Point>, int>(point => new Point(point.X-1,point.Y-1), 7),
                new Tuple<Func<Point, Point>, int>(point => new Point(point.X,point.Y-1), 1),
                new Tuple<Func<Point, Point>, int>(point => new Point(point.X+1,point.Y-1), 1),
                new Tuple<Func<Point, Point>, int>(point => new Point(point.X+1,point.Y), 3),
                new Tuple<Func<Point, Point>, int>(point => new Point(point.X+1,point.Y+1), 3),
                new Tuple<Func<Point, Point>, int>(point => new Point(point.X,point.Y+1), 5),
                new Tuple<Func<Point, Point>, int>(point => new Point(point.X-1,point.Y+1), 5)
            };

            for (int y = 0; y < size.Height; ++y)
            {
                for (int x = 0; x < size.Width; ++x)
                {
                    Point point = new Point(x, y);
                    // Scan for non-transparent pixel
                    if (found.Contains(point) && !inside)
                    {
                        // Entering an already discovered border
                        inside = true;
                        continue;
                    }
                    bool isTransparent = pixels.isTransparent(point);
                    if (!isTransparent && inside)
                    {
                        // Already discovered border point
                        continue;
                    }
                    if (isTransparent && inside)
                    {
                        // Leaving a border
                        inside = false;
                        continue;
                    }
                    if (!isTransparent && !inside)
                    {
                        lists.Add(list = new List<Point>());

                        // Undiscovered border point
                        found.Add(point); list.Add(point);   // Mark the start pixel
                        int checkLocationNr = 1;  // The neighbor number of the location we want to check for a new border point
                        Point startPos = point;      // Set start position
                        int counter = 0;       // Counter is used for the jacobi stop criterion
                        int counter2 = 0;       // Counter2 is used to determine if the point we have discovered is one single point

                        // Trace around the neighborhood
                        while (true)
                        {
                            // The corresponding absolute array address of checkLocationNr
                            Point checkPosition = neighborhood[checkLocationNr - 1].Item1(point);
                            // Variable that holds the neighborhood position we want to check if we find a new border at checkLocationNr
                            int newCheckLocationNr = neighborhood[checkLocationNr - 1].Item2;

                            // Beware that the point might be outside the bitmap.
                            // The isTransparent method contains the safety check.
                            if (!pixels.isTransparent(checkPosition))
                            {
                                // Next border point found
                                if (checkPosition == startPos)
                                {
                                    counter++;

                                    // Stopping criterion (jacob)
                                    if (newCheckLocationNr == 1 || counter >= 3)
                                    {
                                        // Close loop
                                        inside = true; // Since we are starting the search at were we first started we must set inside to true
                                        break;
                                    }
                                }

                                checkLocationNr = newCheckLocationNr; // Update which neighborhood position we should check next
                                point = checkPosition;
                                counter2 = 0;             // Reset the counter that keeps track of how many neighbors we have visited
                                found.Add(point); list.Add(point); // Set the border pixel
                            }
                            else
                            {
                                // Rotate clockwise in the neighborhood
                                checkLocationNr = 1 + (checkLocationNr % 8);
                                if (counter2 > 8)
                                {
                                    // If counter2 is above 8 we have traced around the neighborhood and
                                    // therefor the border is a single black pixel and we can exit
                                    counter2 = 0;
                                    list = null;
                                    break;
                                }
                                else
                                {
                                    counter2++;
                                }
                            }
                        }

                    }
                }
            }
            return lists;
        }

        // This gets the longest boundary (i.e. list of points), if you don't want all boundaries.
        static List<Point> getPoints(List<List<Point>> lists)
        {
            lists.Sort((x, y) => x.Count.CompareTo(y.Count));
            return lists.Last();
        }
    }

    class Pixels
    {
        internal readonly Size size;
        protected readonly int nPixels;
        protected readonly int[] pixels;

        protected Pixels(BitmapData bitmapData)
        {
            size = new Size(bitmapData.Width, bitmapData.Height);
            nPixels = size.Width * size.Height;
            pixels = new int[nPixels];
            System.Runtime.InteropServices.Marshal.Copy(bitmapData.Scan0, pixels, 0, nPixels);
        }

        internal static Pixels create(Bitmap image)
        {
            BitmapData bitmapData = getBitmapData(image, true);
            Pixels rc = new Pixels(bitmapData);
            image.UnlockBits(bitmapData);
            return rc;
        }

        internal static Pixels create(string inputPath)
        {
            using (Bitmap image = new Bitmap(inputPath))
            {
                BitmapData bitmapData = getBitmapData(image, true);
                Pixels rc = new Pixels(bitmapData);
                image.UnlockBits(bitmapData);
                return rc;
            }
        }

        public int this[Point point]
        {
            get
            {
                int n = (point.Y * size.Width) + point.X;
                return pixels[n];
            }
            protected set
            {
                int n = (point.Y * size.Width) + point.X;
                pixels[n] = value;
            }
        }

        internal bool contains(Point point)
        {
            return ((point.X < 0) || (point.X >= size.Width) || (point.Y < 0) || (point.Y >= size.Height)) ? false : true;
        }

        internal bool isColor(Point point, Predicate<int> wanted)
        {
            int pixel = this[point];
            return wanted(pixel);
        }

        internal bool isTransparent(Point point)
        {
            if (!contains(point))
                return true;
            return isColor(point, isTransparent);
        }
        static bool isTransparent(int argb)
        {
            Color color = Color.FromArgb(argb);
            return (color.A == 0);
        }

        protected static BitmapData getBitmapData(Bitmap image, bool isReadOnly)
        {
            Rectangle rect = new Rectangle(new Point(0, 0), image.Size);
            return image.LockBits(rect, (isReadOnly) ? ImageLockMode.ReadOnly : ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
        }
    }

    // This is a writable version of the Pixels class.
    // Don't forget to call the save method (could refactor this to use Dispose instead),
    // and to dispose the Bitmap it's constructed from after you finish with the Pixels2 instance.
    class Pixels2 : Pixels
    {
        internal static new Pixels2 create(Bitmap image)
        {
            BitmapData bitmapData = getBitmapData(image, false);
            return new Pixels2(image, bitmapData);
        }

        readonly Bitmap image;
        readonly BitmapData bitmapData;

        Pixels2(Bitmap image, BitmapData bitmapData)
            : base(bitmapData)
        {
            this.image = image;
            this.bitmapData = bitmapData;
        }

        internal void save(string outputPath)
        {
            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, bitmapData.Scan0, nPixels);
            image.UnlockBits(bitmapData);
            image.Save(outputPath);
        }

        internal void setColor(Point point, int argb)
        {
            base[point] = argb;
        }
    }
}