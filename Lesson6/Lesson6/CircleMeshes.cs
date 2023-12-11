using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Lesson6
{
    public static class CircleMeshes
    {
        public static void DrawPyramid(Vector3 start, float lx, float ly, float lz, Color[] clr,
            bool drawLines)
        {
            var colorIndex = 0;

            var mainPoints = GetVectorsPolygon(8, start.X, start.Y, start.Z);
            var topPoint = new Vector3(start.X, start.Y, start.Z + lz);
            GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Polygon);
            GL.Color4(clr[colorIndex++ % clr.Length]);
            foreach (var point in mainPoints) GL.Vertex3(point);
            GL.End();


            for (var i = 0; i < mainPoints.Length; i++)
            {
                GL.Begin(drawLines ? BeginMode.LineLoop : BeginMode.Triangles);
                GL.Color4(clr[colorIndex++ % clr.Length]);
                GL.Vertex3(topPoint);
                GL.Vertex3(mainPoints[i]);
                GL.Vertex3(mainPoints[(i + 1) % mainPoints.Length]);
                GL.End();
            }
        }


        private static Vector3[] GetVectorsPolygon(int countAngles, float posX, float posY, float z)
        {
            var vectors = new Vector3[countAngles];
            var angle = Math.PI * 2 / countAngles;
            for (var i = 0; i < countAngles; i++)
            {
                var x = (float)(posX + Math.Cos(angle * i) * 100);
                var y = (float)(posY + Math.Sin(angle * i) * 100);
                vectors[i] = new Vector3(x + posX, y + posY, z);
            }

            return vectors;
        }
    }
}