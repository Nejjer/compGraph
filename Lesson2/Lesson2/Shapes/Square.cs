using OpenTK.Graphics;

namespace Lesson2.Shapes
{
    public static class Square
    {
        public static void Draw()
        {
            GL.Begin(BeginMode.Quads);
            Shape.DrawByPoints(4, 1, -1, 4);
            GL.End();
        }
    }
}