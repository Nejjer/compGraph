using System.Drawing;

namespace Lesson1.Shapes
{
    public class Line
    {
        private readonly Pen _backgroundPen;
        private readonly Color _color = Color.Black;
        private readonly Graphics _gr;
        private readonly Pen _pen;
        public int endX = 0;
        public int endY = 0;
        public int startX = 0;
        public int startY = 0;


        public Line(Graphics gr, Color backgroundColor)
        {
            _gr = gr;
            _pen = new Pen(new SolidBrush(_color));
            _backgroundPen = new Pen(new SolidBrush(backgroundColor));
        }

        public void Draw()
        {
            _gr.DrawLine(_pen, new Point(startX, startY), new Point(endX, endY));
        }

        public void Clear()
        {
            _gr.DrawLine(_backgroundPen, new Point(startX, startY), new Point(endX, endY));
        }
    }
}