using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using Tao.OpenGl;

namespace Lesson6
{
    public static class CircleMeshes
    {
        public static void DrawPyramid(Vector3 start, float radius, int countAngles, float lz, Color[] clr,
            bool drawLines)
        {
            var colorIndex = 0;

            var mainPoints = GetVectorsPolygon(countAngles,radius, start.X, start.Y, start.Z);
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


        private static Vector3[] GetVectorsPolygon(int countAngles, float radius, float posX, float posY, float posZ)
        {
            var vectors = new Vector3[countAngles];
            var angle = Math.PI * 2 / countAngles;
            for (var i = 0; i < countAngles; i++)
            {
                var x = (float)(posX + Math.Cos(angle * i) * radius);
                var y = (float)(posY + Math.Sin(angle * i) * radius);
                vectors[i] = new Vector3(x + posX, y + posY, posZ);
            }

            return vectors;
        }
        
        public static void DrawConus(Vector3 start, float radius, float lz, Color[] clr,
            bool drawLines)
        {
            DrawPyramid(start, radius, 64, lz, clr, drawLines);
        }
        
        private static void DrawCone()
        {
            float radius = 100.0f;
            int slices = 32;
            float height = 100.0f;

            GL.Begin(PrimitiveType.TriangleFan);
            GL.Vertex3(0, height, 0); // Apex
            for (int i = 0; i <= slices; i++)
            {
                float angle = (float)i / slices * 2.0f * (float)Math.PI;
                GL.Vertex3((float)Math.Cos(angle) * radius, 0, (float)Math.Sin(angle) * radius);
            }
            GL.End();
        }
    }
}