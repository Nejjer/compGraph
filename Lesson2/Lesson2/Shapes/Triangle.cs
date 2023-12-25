using OpenTK.Graphics;

namespace Lesson2.Shapes
{
    public static class Triangle
    {
        public static void Draw()
        {
            GL.Begin(BeginMode.Triangles);
            Shape.DrawByPoints(3, -1, 1, 4);
            GL.End();
        }
    }
}