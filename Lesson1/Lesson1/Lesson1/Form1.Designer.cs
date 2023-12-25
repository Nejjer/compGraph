namespace Lesson1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LineDrawBtn = new System.Windows.Forms.Button();
            this.LineEndX = new System.Windows.Forms.NumericUpDown();
            this.LineStartX = new System.Windows.Forms.NumericUpDown();
            this.LineStartY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.LineEndY = new System.Windows.Forms.NumericUpDown();
            this.EllipseHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EliipsePosY = new System.Windows.Forms.NumericUpDown();
            this.EllipsePosX = new System.Windows.Forms.NumericUpDown();
            this.EllipseWidth = new System.Windows.Forms.NumericUpDown();
            this.EllipseDrawBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CountOfAngle = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PolygonPosY = new System.Windows.Forms.NumericUpDown();
            this.PolygonPosX = new System.Windows.Forms.NumericUpDown();
            this.PolygonRadius = new System.Windows.Forms.NumericUpDown();
            this.PolygonDrawBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LineEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipseHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliipsePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipsePosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipseWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Линия";
            // 
            // LineDrawBtn
            // 
            this.LineDrawBtn.Location = new System.Drawing.Point(12, 61);
            this.LineDrawBtn.Name = "LineDrawBtn";
            this.LineDrawBtn.Size = new System.Drawing.Size(96, 26);
            this.LineDrawBtn.TabIndex = 1;
            this.LineDrawBtn.Text = "Нарисовать";
            this.LineDrawBtn.UseVisualStyleBackColor = true;
            this.LineDrawBtn.Click += new System.EventHandler(this.LineDrawBtn_Click);
            // 
            // LineEndX
            // 
            this.LineEndX.Location = new System.Drawing.Point(125, 98);
            this.LineEndX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.LineEndX.Name = "LineEndX";
            this.LineEndX.Size = new System.Drawing.Size(116, 20);
            this.LineEndX.TabIndex = 7;
            this.LineEndX.ValueChanged += new System.EventHandler(this.LineEndX_ValueChanged);
            // 
            // LineStartX
            // 
            this.LineStartX.Location = new System.Drawing.Point(125, 51);
            this.LineStartX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.LineStartX.Name = "LineStartX";
            this.LineStartX.Size = new System.Drawing.Size(116, 20);
            this.LineStartX.TabIndex = 8;
            this.LineStartX.ValueChanged += new System.EventHandler(this.LineStartX_ValueChanged);
            // 
            // LineStartY
            // 
            this.LineStartY.Location = new System.Drawing.Point(261, 51);
            this.LineStartY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.LineStartY.Name = "LineStartY";
            this.LineStartY.Size = new System.Drawing.Size(116, 20);
            this.LineStartY.TabIndex = 9;
            this.LineStartY.ValueChanged += new System.EventHandler(this.LineStartY_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(125, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start X";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(262, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Start Y";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(262, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "End Y";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(125, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "End X";
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Location = new System.Drawing.Point(400, 90);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(374, 326);
            this.DrawingPanel.TabIndex = 15;
            // 
            // LineEndY
            // 
            this.LineEndY.Location = new System.Drawing.Point(261, 98);
            this.LineEndY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.LineEndY.Name = "LineEndY";
            this.LineEndY.Size = new System.Drawing.Size(116, 20);
            this.LineEndY.TabIndex = 16;
            this.LineEndY.ValueChanged += new System.EventHandler(this.LineEndY_ValueChanged);
            // 
            // EllipseHeight
            // 
            this.EllipseHeight.Location = new System.Drawing.Point(261, 220);
            this.EllipseHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.EllipseHeight.Name = "EllipseHeight";
            this.EllipseHeight.Size = new System.Drawing.Size(116, 20);
            this.EllipseHeight.TabIndex = 27;
            this.EllipseHeight.ValueChanged += new System.EventHandler(this.EllipseHeight_ValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(125, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "Width";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(262, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "Height";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(262, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Eliipse Pos Y";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(125, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Eliipse Pos X";
            // 
            // EliipsePosY
            // 
            this.EliipsePosY.Location = new System.Drawing.Point(261, 173);
            this.EliipsePosY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.EliipsePosY.Name = "EliipsePosY";
            this.EliipsePosY.Size = new System.Drawing.Size(116, 20);
            this.EliipsePosY.TabIndex = 22;
            this.EliipsePosY.ValueChanged += new System.EventHandler(this.EliipsePosY_ValueChanged);
            // 
            // EllipsePosX
            // 
            this.EllipsePosX.Location = new System.Drawing.Point(125, 173);
            this.EllipsePosX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.EllipsePosX.Name = "EllipsePosX";
            this.EllipsePosX.Size = new System.Drawing.Size(116, 20);
            this.EllipsePosX.TabIndex = 21;
            this.EllipsePosX.ValueChanged += new System.EventHandler(this.EllipsePosX_ValueChanged);
            // 
            // EllipseWidth
            // 
            this.EllipseWidth.Location = new System.Drawing.Point(125, 220);
            this.EllipseWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.EllipseWidth.Name = "EllipseWidth";
            this.EllipseWidth.Size = new System.Drawing.Size(116, 20);
            this.EllipseWidth.TabIndex = 20;
            this.EllipseWidth.ValueChanged += new System.EventHandler(this.EllipseWidth_ValueChanged);
            // 
            // EllipseDrawBtn
            // 
            this.EllipseDrawBtn.Location = new System.Drawing.Point(12, 183);
            this.EllipseDrawBtn.Name = "EllipseDrawBtn";
            this.EllipseDrawBtn.Size = new System.Drawing.Size(96, 26);
            this.EllipseDrawBtn.TabIndex = 18;
            this.EllipseDrawBtn.Text = "Нарисовать";
            this.EllipseDrawBtn.UseVisualStyleBackColor = true;
            this.EllipseDrawBtn.Click += new System.EventHandler(this.EllipseDrawBtn_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "Элипс";
            // 
            // CountOfAngle
            // 
            this.CountOfAngle.Location = new System.Drawing.Point(261, 360);
            this.CountOfAngle.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.CountOfAngle.Name = "CountOfAngle";
            this.CountOfAngle.Size = new System.Drawing.Size(116, 20);
            this.CountOfAngle.TabIndex = 38;
            this.CountOfAngle.ValueChanged += new System.EventHandler(this.CountOfAngle_ValueChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(125, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 12);
            this.label11.TabIndex = 37;
            this.label11.Text = "Radius";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(262, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 12);
            this.label12.TabIndex = 36;
            this.label12.Text = "Кол-во углов";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(262, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 24);
            this.label13.TabIndex = 35;
            this.label13.Text = "Pos Y";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(125, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 19);
            this.label14.TabIndex = 34;
            this.label14.Text = "Pos X";
            // 
            // PolygonPosY
            // 
            this.PolygonPosY.Location = new System.Drawing.Point(261, 313);
            this.PolygonPosY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.PolygonPosY.Name = "PolygonPosY";
            this.PolygonPosY.Size = new System.Drawing.Size(116, 20);
            this.PolygonPosY.TabIndex = 33;
            this.PolygonPosY.ValueChanged += new System.EventHandler(this.PolygonPosY_ValueChanged);
            // 
            // PolygonPosX
            // 
            this.PolygonPosX.Location = new System.Drawing.Point(125, 313);
            this.PolygonPosX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.PolygonPosX.Name = "PolygonPosX";
            this.PolygonPosX.Size = new System.Drawing.Size(116, 20);
            this.PolygonPosX.TabIndex = 32;
            this.PolygonPosX.ValueChanged += new System.EventHandler(this.PolygonPosX_ValueChanged);
            // 
            // PolygonRadius
            // 
            this.PolygonRadius.Location = new System.Drawing.Point(125, 360);
            this.PolygonRadius.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.PolygonRadius.Name = "PolygonRadius";
            this.PolygonRadius.Size = new System.Drawing.Size(116, 20);
            this.PolygonRadius.TabIndex = 31;
            this.PolygonRadius.ValueChanged += new System.EventHandler(this.PolygonRadius_ValueChanged);
            // 
            // PolygonDrawBtn
            // 
            this.PolygonDrawBtn.Location = new System.Drawing.Point(12, 323);
            this.PolygonDrawBtn.Name = "PolygonDrawBtn";
            this.PolygonDrawBtn.Size = new System.Drawing.Size(96, 26);
            this.PolygonDrawBtn.TabIndex = 29;
            this.PolygonDrawBtn.Text = "Нарисовать";
            this.PolygonDrawBtn.UseVisualStyleBackColor = true;
            this.PolygonDrawBtn.Click += new System.EventHandler(this.PolygonDrawBtn_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(0, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 26);
            this.label15.TabIndex = 28;
            this.label15.Text = "Правильный Многоугольник";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(122, 443);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 12);
            this.label16.TabIndex = 48;
            this.label16.Text = "Вершины";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 26);
            this.button2.TabIndex = 40;
            this.button2.Text = "Нарисовать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(0, 409);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 26);
            this.label20.TabIndex = 39;
            this.label20.Text = "Многоугольник";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 461);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.CountOfAngle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PolygonPosY);
            this.Controls.Add(this.PolygonPosX);
            this.Controls.Add(this.PolygonRadius);
            this.Controls.Add(this.PolygonDrawBtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.EllipseHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EliipsePosY);
            this.Controls.Add(this.EllipsePosX);
            this.Controls.Add(this.EllipseWidth);
            this.Controls.Add(this.EllipseDrawBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LineEndY);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LineStartY);
            this.Controls.Add(this.LineStartX);
            this.Controls.Add(this.LineEndX);
            this.Controls.Add(this.LineDrawBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LineEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipseHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EliipsePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipsePosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipseWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolygonRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.NumericUpDown CountOfAngle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown PolygonPosY;
        private System.Windows.Forms.NumericUpDown PolygonPosX;
        private System.Windows.Forms.NumericUpDown PolygonRadius;
        private System.Windows.Forms.Button PolygonDrawBtn;
        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.NumericUpDown EllipseHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown EliipsePosY;
        private System.Windows.Forms.NumericUpDown EllipsePosX;
        private System.Windows.Forms.NumericUpDown EllipseWidth;
        private System.Windows.Forms.Button EllipseDrawBtn;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.NumericUpDown LineEndY;

        private System.Windows.Forms.Panel DrawingPanel;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.NumericUpDown LineEndX;
        private System.Windows.Forms.NumericUpDown LineStartX;
        private System.Windows.Forms.NumericUpDown LineStartY;

        private System.Windows.Forms.Button LineDrawBtn;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}