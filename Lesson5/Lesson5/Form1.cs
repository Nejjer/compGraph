using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class Form1 : Form
    {
        private readonly Bitmap myBitmap;

        public Form1()
        {
            InitializeComponent();
            String path = @"img\tyan.jpg";
            myBitmap = new Bitmap(path);
            pictureBox1.Image = myBitmap;
            Console.WriteLine(myBitmap.GetPixel(20, 20));


            pictureBox2.Image = ToGrayScale(myBitmap);
        }

        private Bitmap ToGrayScale(Bitmap bitmap)
        {
            var grayScaleBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (var x = 0; x < bitmap.Width; x++)
            for (var y = 0; y < bitmap.Height; y++)
                if (bitmap.GetPixel(x, y).GetBrightness() < 0.5)
                    grayScaleBitmap.SetPixel(x, y, Color.Black);
                else
                    grayScaleBitmap.SetPixel(x, y, Color.White);

            return grayScaleBitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var me = (MouseEventArgs)e;
            var coordinates = me.Location;
            xText.Text = coordinates.X.ToString();
            yText.Text = coordinates.Y.ToString();
            getAndSetColor();
        }

        private void getAndSetColor()
        {
            try
            {
                var x = int.Parse(xText.Text);
                var y = int.Parse(yText.Text);
                var colorBitmap = new Bitmap(colorPicture.Width, colorPicture.Height);
                for (var i = 0; i < colorPicture.Width; i++)
                for (var j = 0; j < colorPicture.Height; j++)
                    colorBitmap.SetPixel(i, j, myBitmap.GetPixel(x, y));
                colorPicture.Image = colorBitmap;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAndSetColor();
        }
    }
}