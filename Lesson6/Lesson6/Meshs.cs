using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Lesson6
{
    public static class Meshs
    {
        public static void DrawBox()
        {
            var bgmode = BeginMode.Polygon;

            GL.Begin(bgmode);

            // Front face
            GL.Color3(Color.Red);
            GL.Vertex3(-100f, -100f, 100f);
            GL.Vertex3(100f, -100f, 100f);
            GL.Vertex3(100f, 100f, 100f);
            GL.Vertex3(-100f, 100f, 100f);
            GL.End();
            GL.Begin(bgmode);

            // Back face
            GL.Color3(Color.Green);
            GL.Vertex3(-100f, -100f, -100f);
            GL.Vertex3(100f, -100f, -100f);
            GL.Vertex3(100f, 100f, -100f);
            GL.Vertex3(-100f, 100f, -100f);
            GL.End();
            GL.Begin(bgmode);

            // Top face
            GL.Color3(Color.Blue);
            GL.Vertex3(-100f, 100f, -100f);
            GL.Vertex3(100f, 100f, -100f);
            GL.Vertex3(100f, 100f, 100f);
            GL.Vertex3(-100f, 100f, 100f);
            GL.End();
            GL.Begin(bgmode);

            // Bottom face
            GL.Color3(Color.Yellow);
            GL.Vertex3(-100f, -100f, -100f);
            GL.Vertex3(100f, -100f, -100f);
            GL.Vertex3(100f, -100f, 100f);
            GL.Vertex3(-100f, -100f, 100f);
            GL.End();
            GL.Begin(bgmode);

            // Left face
            GL.Color3(Color.Cyan);
            GL.Vertex3(-100f, -100f, -100f);
            GL.Vertex3(-100f, -100f, 100f);
            GL.Vertex3(-100f, 100f, 100f);
            GL.Vertex3(-100f, 100f, -100f);
            GL.End();
            GL.Begin(bgmode);

            // Right face
            GL.Color3(Color.Aqua);
            GL.Vertex3(100f, -100f, -100f);
            GL.Vertex3(100f, -100f, 100f);
            GL.Vertex3(100f, 100f, 100f);
            GL.Vertex3(100f, 100f, -100f);

            GL.End();
        }

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
    }
}