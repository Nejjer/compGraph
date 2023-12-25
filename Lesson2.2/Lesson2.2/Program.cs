using System;
using Lesson2.Shapes;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;

namespace Lesson2._2
{
    internal class Game : GameWindow
    {
        private readonly Polygon _polygon;
        private const int WindowWidth = 1024;
        private const int WindowHeight = 1024;
        private float _speedX = 0.01f;
        private float _speedY = 0.02f;
        private float _scale = 0.001f;
        private bool minOffser = false;

        public Game() : base(WindowWidth, WindowHeight, GraphicsMode.Default, "Open TK sample")
        {
            VSync = VSyncMode.On;
            _polygon = new Polygon(0, 0, 4);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(0.1f, 0.2f, 0.5f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            var projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4,
                Width / (float)Height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            if (Keyboard[Key.Escape])
                Exit();
        }



        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            var modelview = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);
            Scale();
            Translate();

            _polygon.Draw();
            _polygon.Rotate(Math.PI / 180);

            GL.Scale(new Vector3(1,1,1));
            SwapBuffers();
        }

        public void Scale()
        {
            _polygon.Scale(_scale);

            if (Math.Abs(_polygon._scale - 0.1) < 0.1)
            {
                _scale *= -1;
            }

            if (Math.Abs(_polygon._scale - 1) < 0.1)
            {
                _scale *= -1;
            }
        }

        private void Translate()
        {
            _polygon.Translate(_speedX, _speedY);
            //_polygon.Scale(_scale);
            float bounders = 2;
            float posX = _polygon._posX;
            float posY = _polygon._posY;
            float radius = _polygon._scale;
            if (Math.Abs(posX - bounders + radius) < 0.2 || Math.Abs(posX - (-bounders + radius)) < 0.2)
            {
                _speedX *= -1;
            }
            if (Math.Abs(posY - bounders + radius) < 0.1 || Math.Abs(posY + bounders - radius) < 0.1)
            {
                _speedY *= -1;
            }
        }

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (var game = new Game())
            {
                game.Run(25);
            }
        }
    }
}