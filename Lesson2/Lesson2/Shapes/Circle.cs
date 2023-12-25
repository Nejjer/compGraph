using OpenTK.Graphics;

namespace Lesson2.Shapes
{
    public static class Circle
    {
        public static void Draw()
        {
            GL.Begin(BeginMode.Polygon);
            //Круг это просто многоугольник с большим количеством углов
            Shape.DrawByPoints(50, 1, 1, 4);
            GL.End();
        }
    }
}