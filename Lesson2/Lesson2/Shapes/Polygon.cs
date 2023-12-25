using OpenTK.Graphics;

namespace Lesson2.Shapes
{
    public static class Polygon
    {
        public static void Draw()
        {
            GL.Begin(BeginMode.Polygon);
            Shape.DrawByPoints(5, -1, -1, 4);
            GL.End();
        }
    }
}