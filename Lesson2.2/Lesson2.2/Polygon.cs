using System;
using OpenTK;
using OpenTK.Graphics;

namespace Lesson2.Shapes
{
    public class Polygon
    {
        private readonly int _countAngles;
        private readonly float _posZ;
        public float _posX;
        public float _posY;
        private double _rotate = Math.PI / 4;
        public float _scale = 0.5f;

        public Polygon(float posX, float posY, float posZ, int countAngles = 5)
        {
            _countAngles = countAngles;
            _posX = posX;
            _posY = posY;
            _posZ = posZ;
        }

        public void Draw()
        {
            GL.Begin(BeginMode.Polygon);
            DrawByPoints(_countAngles, _posX, _posY, _posZ);
            GL.End();
        }

        public void Rotate(double rotate)
        {
            _rotate += rotate;
        }

        public void Scale(float scale)
        {
            _scale += scale;
        }

        public void Translate(float x, float y)
        {
            _posX += x;
            _posY += y;
        }

        private void DrawByPoints(int countAngles, float posX, float posY, float z)
        {
            foreach (var vector in
                     GetVectorsPolygon(countAngles, posX, posY, z)) GL.Vertex3(vector);
        }

        private Vector3[] GetVectorsPolygon(int countAngles, float posX, float posY, float z)
        {
            var vectors = new Vector3[countAngles];
            var angle = Math.PI * 2 / countAngles;
            for (var i = 0; i < countAngles; i++)
            {
                var x = (float)(posX + Math.Cos(angle * i + _rotate) * _scale);
                var y = (float)(posY + Math.Sin(angle * i + _rotate) * _scale);
                vectors[i] = new Vector3(x, y, z);
            }

            return vectors;
        }
    }
}