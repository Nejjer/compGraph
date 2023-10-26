using System;
using System.Windows.Forms;
using Lesson1.Shapes;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        private readonly Ellipse _ellipse;
        private readonly Line _line;
        private readonly Polygon _polygon;

        public Form1()
        {
            InitializeComponent();
            var gr = DrawingPanel.CreateGraphics();
            _line = new Line(gr, BackColor);
            _ellipse = new Ellipse(gr, BackColor);
            _polygon = new Polygon(gr, BackColor);
        }

        //Линия
        private void LineDrawBtn_Click(object sender, EventArgs e)
        {
            _line.Draw();
        }

        private void LineEndY_ValueChanged(object sender, EventArgs e)
        {
            _line.endY = (int)LineEndY.Value;
        }

        private void LineEndX_ValueChanged(object sender, EventArgs e)
        {
            _line.endX = (int)LineEndX.Value;
        }

        private void LineStartX_ValueChanged(object sender, EventArgs e)
        {
            _line.startX = (int)LineStartX.Value;
        }

        private void LineStartY_ValueChanged(object sender, EventArgs e)
        {
            _line.startY = (int)LineStartY.Value;
        }

        private void LineClearBtn_Click(object sender, EventArgs e)
        {
            _line.Clear();
        }

        //Эллипс
        private void EllipseDrawBtn_Click(object sender, EventArgs e)
        {
            _ellipse.Draw();
        }

        private void EliipseClearBtn_Click(object sender, EventArgs e)
        {
            _ellipse.Clear();
        }

        private void EllipsePosX_ValueChanged(object sender, EventArgs e)
        {
            _ellipse.posX = (int)EllipsePosX.Value;
        }

        private void EllipseWidth_ValueChanged(object sender, EventArgs e)
        {
            _ellipse.width = (int)EllipseWidth.Value;
        }

        private void EliipsePosY_ValueChanged(object sender, EventArgs e)
        {
            _ellipse.posY = (int)EliipsePosY.Value;
        }

        private void EllipseHeight_ValueChanged(object sender, EventArgs e)
        {
            _ellipse.height = (int)EllipseHeight.Value;
        }

        private void PolygonDrawBtn_Click(object sender, EventArgs e)
        {
            _polygon.Draw();
        }

        private void PolyhonClearBtn_Click(object sender, EventArgs e)
        {
            _polygon.Clear();
        }

        private void PolygonPosX_ValueChanged(object sender, EventArgs e)
        {
            _polygon.posX = (int)PolygonPosX.Value;
        }

        private void PolygonRadius_ValueChanged(object sender, EventArgs e)
        {
            _polygon.radius = (int)PolygonRadius.Value;
        }

        private void PolygonPosY_ValueChanged(object sender, EventArgs e)
        {
            _polygon.posY = (int)PolygonPosY.Value;
        }

        private void CountOfAngle_ValueChanged(object sender, EventArgs e)
        {
            _polygon.countOfAngle = (int)CountOfAngle.Value;
        }
    }
}