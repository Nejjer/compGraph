using System;
using OpenTK;
using OpenTK.Graphics;

namespace Lesson2.Shapes
{
    internal static class Shape
    {
        public static void DrawByPoints(int countAngles, float posX, float posY, float z)
        {
            foreach (var vector in
                     GetVectorsPolygon(countAngles, posX, posY, z)) GL.Vertex3(vector); 
        }

        private static Vector3[] GetVectorsPolygon(int countAngles, float posX, float posY, float z)
        {
            var vectors = new Vector3[countAngles];
            var angle = Math.PI * 2 / countAngles;
            var rotate = Math.PI / 4;
            var scale = 0.5f;
            for (var i = 0; i < countAngles; i++)
            {
                var x = (float)(posX + Math.Cos(angle * i + rotate) * scale);
                var y = (float)(posY + Math.Sin(angle * i + rotate) * scale);
                vectors[i] = new Vector3(x, y, z);
            }

            return vectors;
        }
    }
}