using System;
using OpenTK;
using OpenTK.Graphics;

public enum Direction
{
    West,
    South,
    East,
    North
}
namespace Lesson4
{
    public class Fractal
    {
        public void Draw( float x, float y,float size, int n, Direction dir)
        {
            //DrawSquare(0,0,2);
            int n1 = n - 1;
            float fr = 0.4f * size, cr = 1.4f * size;
            if (n > 0)
            {
                Draw(x + cr, y, fr, n1, Direction.East);
                Draw(x, y + cr, fr, n1, Direction.North);
                Draw(x - cr, y, fr, n1, Direction.West);
                Draw(x, y - cr, fr, n1, Direction.South);
                DrawSquare(x,y,size);
            }
        }

        private void DrawSquare(float x, float y, float size)
        {
            GL.Begin(BeginMode.Quads);
            var z = 10;
            float xA, xB, xC, xD, yA, yB, yC, yD;
            xA = x - size;
            yA = y - size;
            xB = x + size;
            yB = y - size;
            xC = x + size;
            yC = y + size;
            xD = x - size;
            yD = y + size;
            GL.Vertex3(xA, yA, z);
            GL.Vertex3(xB, yB, z);
            GL.Vertex3(xC, yC, z);
            GL.Vertex3(xD, yD, z);
            GL.End();
        }
    }
}