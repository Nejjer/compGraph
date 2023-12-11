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

            //top
            GL.Color4(clr[i++]);
            GL.Vertex3(start.X, start.Y, start.Z + lz);
            GL.Vertex3(start.X + lx, start.Y, start.Z + lz);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z + lz);
            GL.Vertex3(start.X, start.Y + ly, start.Z + lz);

            //bottom
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(start.X, start.Y + ly, start.Z);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z);
            GL.Vertex3(start.X + lx, start.Y, start.Z);
            GL.Vertex3(start.X, start.Y, start.Z);

            //front
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(start.X, start.Y, start.Z);
            GL.Vertex3(start.X, start.Y, start.Z + lz);
            GL.Vertex3(start.X, start.Y + ly, start.Z + lz);
            GL.Vertex3(start.X, start.Y + ly, start.Z);

            //right
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(start.X, start.Y, start.Z);
            GL.Vertex3(start.X + lx, start.Y, start.Z);
            GL.Vertex3(start.X + lx, start.Y, start.Z + lz);
            GL.Vertex3(start.X, start.Y, start.Z + lz);

            //left
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(start.X, start.Y + ly, start.Z + lz);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z + lz);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z);
            GL.Vertex3(start.X, start.Y + ly, start.Z);

            //back
            GL.Color4(clr[i++ % clr.Length]);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z);
            GL.Vertex3(start.X + lx, start.Y + ly, start.Z + lz);
            GL.Vertex3(start.X + lx, start.Y, start.Z + lz);
            GL.Vertex3(start.X + lx, start.Y, start.Z);

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
    }
}