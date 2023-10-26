﻿using System.Drawing;

namespace Lesson1.Shapes
{
    public class Ellipse
    {
        private readonly SolidBrush _backgroundBrush;
        private readonly SolidBrush _brush;
        private readonly Color _color = Color.Black;
        private readonly Graphics _gr;
        public int height = 0;
        public int posX = 0;
        public int posY = 0;
        public int width = 0;


        public Ellipse(Graphics gr, Color backgroundColor)
        {
            _gr = gr;
            _brush = new SolidBrush(_color);
            _backgroundBrush = new SolidBrush(backgroundColor);
        }

        public void Draw()
        {
            _gr.FillEllipse(_brush, posX, posY, width, height);
        }

        public void Clear()
        {
            _gr.FillEllipse(_backgroundBrush, posX, posY, width, height);
        }
    }
}