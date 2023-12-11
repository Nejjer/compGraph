using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Lesson6
{
    public static class Meshs
    {
        public static void DrawParallelepiped(Vector3 start, float lx, float ly, float lz, Color[] clr, bool drawLines)
        {
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            var i = 0;

            var xMin = start.X;
            var xMax = start.X + lx;
            var yMin = start.Y;
            var yMax = start.Y + ly;
            var zMin = start.Z;
            var zMax = start.Z + lz;

            //top
            GL.Color4(clr[i++]);
            GL.Vertex3(xMin, yMin, zMax);
            GL.Vertex3(xMax, yMin, zMax);
            GL.Vertex3(xMax, yMax, zMax);
            GL.Vertex3(xMin, yMax, zMax);

            //bottom
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(xMin, yMax, zMin);
            GL.Vertex3(xMax, yMax, zMin);
            GL.Vertex3(xMax, yMin, zMin);
            GL.Vertex3(xMin, yMin, zMin);

            //front
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(xMin, yMin, zMin);
            GL.Vertex3(xMin, yMin, zMax);
            GL.Vertex3(xMin, yMax, zMax);
            GL.Vertex3(xMin, yMax, zMin);

            //right
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(xMin, yMin, zMin);
            GL.Vertex3(xMax, yMin, zMin);
            GL.Vertex3(xMax, yMin, zMax);
            GL.Vertex3(xMin, yMin, zMax);

            //left
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(xMin, yMax, zMax);
            GL.Vertex3(xMax, yMax, zMax);
            GL.Vertex3(xMax, yMax, zMin);
            GL.Vertex3(xMin, yMax, zMin);

            //back
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(xMax, yMax, zMin);
            GL.Vertex3(xMax, yMax, zMax);
            GL.Vertex3(xMax, yMin, zMax);
            GL.Vertex3(xMax, yMin, zMin);


            GL.End();
        }

        public static void DrawPyramid(Vector3 start, float lx, float ly, float lz, Color[] clr, bool drawLines)
        {
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            var i = 0;

            //bottom
            GL.Color4(clr[i++]);
            GL.Vertex3(start.X, start.Y + ly, start.Z);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z);
            GL.Vertex3(start.X + lx, start.Y, start.Z);
            GL.Vertex3(start.X, start.Y, start.Z);
            GL.End();

            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Triangles);

            var point = new Vector3((start.X + lx) / 2, (start.Y + ly) / 2, start.Z + lz);

            //front
            GL.Color4(clr[i++]);
            GL.Vertex3(point);
            GL.Vertex3(start.X, start.Y, start.Z);
            GL.Vertex3(start.X, start.Y + ly, start.Z);

            //left
            GL.Color4(clr[i++]);
            GL.Vertex3(point);
            GL.Vertex3(start.X, start.Y + ly, start.Z);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z);

            //back
            GL.Color4(clr[i++]);
            GL.Vertex3(point);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z);
            GL.Vertex3(start.X + lx, start.Y, start.Z);

            //right
            GL.Color4(clr[i++]);
            GL.Vertex3(point);
            GL.Vertex3(start.X + lx, start.Y, start.Z);
            GL.Vertex3(start.X, start.Y, start.Z);

            GL.End();
        }

        public static void DrawTrapezoid(Vector3 start, float lx, float ly, float lz, Color[] clr, bool drawLines)
        {
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Quads);
            var i = 0;

            var ratio = 0.6f;

            var xMin = start.X * ratio;
            var xMax = (start.X + lx) * ratio;
            var yMin = start.Y * ratio;
            var yMax = (start.Y + ly) * ratio;
            var zMin = start.Z;
            var zMax = (start.Z + lz) * ratio;

            //top
            GL.Color4(clr[i++]);
            GL.Vertex3(xMin, yMin, zMax);
            GL.Vertex3(xMax, yMin, zMax);
            GL.Vertex3(xMax, yMax, zMax);
            GL.Vertex3(xMin, yMax, zMax);

            //bottom
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(start.X, start.Y + ly, start.Z);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z);
            GL.Vertex3(start.X + lx, start.Y, start.Z);
            GL.Vertex3(start.X, start.Y, start.Z);

            //front
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(start.X, start.Y, zMin);
            GL.Vertex3(xMin, yMin, zMax);
            GL.Vertex3(xMin, yMax, zMax);
            GL.Vertex3(start.X, start.Y + ly, zMin);

            //right
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(start.X, start.Y, zMin);
            GL.Vertex3(start.X + lx, start.Y, zMin);
            GL.Vertex3(xMax, yMin, zMax);
            GL.Vertex3(xMin, yMin, zMax);

            //left
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(xMin, yMax, zMax);
            GL.Vertex3(xMax, yMax, zMax);
            GL.Vertex3(start.X + lx, start.Y + ly, zMin);
            GL.Vertex3(start.X, start.Y + ly, zMin);

            //back
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(start.X + lx, start.Y + ly, zMin);
            GL.Vertex3(xMax, yMax, zMax);
            GL.Vertex3(xMax, yMin, zMax);
            GL.Vertex3(start.X + lx, start.Y, zMin);

            GL.End();
        }
    }
}