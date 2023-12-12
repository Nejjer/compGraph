﻿using System;
using System.Drawing;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Lesson6
{
    public partial class Form1 : Form
    {
        private double _angle;
        private double _dangle;
        private bool _loaded;

        public Form1()
        {
            InitializeComponent();
        }

        private void SetupViewport(GLControl glControl)
        {
            var aspectRatio = (float)glControl.Width / glControl.Height;
            GL.Viewport(0, 0, glControl.Width, glControl.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            var perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspectRatio, 1f, 5000000000);
            GL.MultMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _loaded = true;
            SetupViewport(glControl1); //установка вида
            ComboBoxDirection.SelectedIndex = 0;
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!_loaded) return;

            //onload
            GL.ClearColor(0.1f, 0.2f, 0.5f, 0.0f); //background color
            GL.Enable(EnableCap.DepthTest);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            //view choice
            var modelView = Matrix4.LookAt(new Vector3(-300, 300, 200), new Vector3(0, 0, 0), new Vector3(0, 0, 1));
            //Vid(comboBox1.SelectedIndex.ToString());

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);

            //choice axis rotation
            switch (ComboBoxDirection.Text)
            {
                case "x":
                    GL.Rotate(_angle, 1, 0, 0);
                    break;
                case "y":
                    GL.Rotate(_angle, 0, 1, 0);
                    break;
                case "z":
                    GL.Rotate(_angle, 0, 0, 1);
                    break;
            }

            var clr1 = new Vector3(1.0f, 1.0f, 0.0f);
            var clr2 = new Vector3(1.0f, 0.0f, 0.0f);
            var clr3 = new Vector3(0.2f, 0.9f, 1.0f);

            //Рисуем оси
            GL.Begin(BeginMode.Lines);
            GL.Color3(clr1); //X-желтая
            GL.Vertex3(-300.0f, 0.0f, 0.0f);
            GL.Vertex3(300.0f, 0.0f, 0.0f);
            GL.End();

            GL.Begin(BeginMode.Lines);
            GL.Color3(clr2); //Y-красная
            GL.Vertex3(0.0f, -300.0f, 0.0f);
            GL.Vertex3(0.0f, 300.0f, 0.0f);
            GL.End();
            GL.Begin(BeginMode.Lines);
            GL.Color3(clr3); //Z-голубая
            GL.Vertex3(0.0f, 0.0f, -300f);
            GL.Vertex3(0.0f, 0.0f, 300.0f);
            GL.End();

            // Meshs.DrawParallelepiped(new Vector3(10, 10, 10), 100, 100, 100,
            //     new[] { Color.Aqua, Color.Blue, Color.Brown, Color.Chocolate, Color.Chartreuse, Color.Purple },
            //     true);

            CircleMeshes.DrawSphere(new Vector3(0, 0, 0), 100, 4, 8, 100,
                new[] { Color.Aqua, Color.Blue, Color.Crimson,  },
                false);

            glControl1.SwapBuffers();
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!_loaded) return;
            SetupViewport(glControl1);
        }

        private void ButtonRotate_Click(object sender, EventArgs e)
        {
            _dangle = (double)numericUpDown1.Value;
            _angle += _dangle;
            glControl1.Invalidate();
        }


        private void ButtonZeroAgnle_Click(object sender, EventArgs e)
        {
            _angle = 0;
            glControl1.Invalidate();
        }
    }
}