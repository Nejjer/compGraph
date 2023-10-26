using System;
using System.Drawing;

namespace Lesson1.Shapes
{
    public class Polygon
    {
        private readonly SolidBrush _backgroundBrush;
        private readonly SolidBrush _brush;
        private readonly Color _color = Color.Black;
        private readonly Graphics _gr;
        public int countOfAngle = 0;
        public int posX = 0;
        public int posY = 0;
        public int radius = 0;


        public Polygon(Graphics gr, Color backgroundColor)
        {
            _gr = gr;
            _brush = new SolidBrush(_color);
            _backgroundBrush = new SolidBrush(backgroundColor);
        }

        public void Draw()
        {
            _gr.FillPolygon(_brush, GetPoints());
        }

        public void Clear()
        {
            _gr.FillPolygon(_backgroundBrush, GetPoints());
        }

        public Point[] GetPoints()
        {
            var points = new Point[countOfAngle];
            var angle = Math.PI * 2 / countOfAngle;

            for (var i = 0; i < countOfAngle; i++)
            {
                var x = (int)(posX + Math.Cos(angle * i) * radius);
                var y = (int)(posY + Math.Sin(angle * i) * radius);
                points[i] = new Point(x, y);
            }

            return points;
        }
    }
}