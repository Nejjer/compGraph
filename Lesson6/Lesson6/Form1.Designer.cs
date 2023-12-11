namespace Lesson6
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
            this.ButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ButtonZeroAgnle = new System.Windows.Forms.Button();
            this.ButtonRotate = new System.Windows.Forms.Button();
            this.ComboBoxDirection = new System.Windows.Forms.ComboBox();
            this.DrawingGroupBox = new System.Windows.Forms.GroupBox();
            this.glControl1 = new OpenTK.GLControl();
            this.ButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.DrawingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsGroupBox
            // 
            this.ButtonsGroupBox.Controls.Add(this.numericUpDown1);
            this.ButtonsGroupBox.Controls.Add(this.ButtonZeroAgnle);
            this.ButtonsGroupBox.Controls.Add(this.ButtonRotate);
            this.ButtonsGroupBox.Controls.Add(this.ComboBoxDirection);
            this.ButtonsGroupBox.Location = new System.Drawing.Point(6, 526);
            this.ButtonsGroupBox.Name = "ButtonsGroupBox";
            this.ButtonsGroupBox.Size = new System.Drawing.Size(457, 127);
            this.ButtonsGroupBox.TabIndex = 0;
            this.ButtonsGroupBox.TabStop = false;
            this.ButtonsGroupBox.Text = "Buttons";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // ButtonZeroAgnle
            // 
            this.ButtonZeroAgnle.Location = new System.Drawing.Point(10, 90);
            this.ButtonZeroAgnle.Name = "ButtonZeroAgnle";
            this.ButtonZeroAgnle.Size = new System.Drawing.Size(126, 24);
            this.ButtonZeroAgnle.TabIndex = 2;
            this.ButtonZeroAgnle.Text = "Angle=0";
            this.ButtonZeroAgnle.UseVisualStyleBackColor = true;
            this.ButtonZeroAgnle.Click += new System.EventHandler(this.ButtonZeroAgnle_Click);
            // 
            // ButtonRotate
            // 
            this.ButtonRotate.Location = new System.Drawing.Point(9, 60);
            this.ButtonRotate.Name = "ButtonRotate";
            this.ButtonRotate.Size = new System.Drawing.Size(126, 24);
            this.ButtonRotate.TabIndex = 1;
            this.ButtonRotate.Text = "Rotate";
            this.ButtonRotate.UseVisualStyleBackColor = true;
            this.ButtonRotate.Click += new System.EventHandler(this.ButtonRotate_Click);
            // 
            // ComboBoxDirection
            // 
            this.ComboBoxDirection.FormattingEnabled = true;
            this.ComboBoxDirection.Items.AddRange(new object[] { "x", "y", "z" });
            this.ComboBoxDirection.Location = new System.Drawing.Point(8, 22);
            this.ComboBoxDirection.Name = "ComboBoxDirection";
            this.ComboBoxDirection.Size = new System.Drawing.Size(128, 21);
            this.ComboBoxDirection.TabIndex = 0;
            // 
            // DrawingGroupBox
            // 
            this.DrawingGroupBox.Controls.Add(this.glControl1);
            this.DrawingGroupBox.Location = new System.Drawing.Point(6, 12);
            this.DrawingGroupBox.Name = "DrawingGroupBox";
            this.DrawingGroupBox.Size = new System.Drawing.Size(712, 496);
            this.DrawingGroupBox.TabIndex = 1;
            this.DrawingGroupBox.TabStop = false;
            this.DrawingGroupBox.Text = "Canvas";
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Azure;
            this.glControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glControl1.Location = new System.Drawing.Point(6, 19);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(700, 471);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 665);
            this.Controls.Add(this.DrawingGroupBox);
            this.Controls.Add(this.ButtonsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.DrawingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown numericUpDown1;

        private System.Windows.Forms.Button ButtonRotate;
        private System.Windows.Forms.Button ButtonZeroAgnle;

        private System.Windows.Forms.ComboBox ComboBoxDirection;

        private System.Windows.Forms.GroupBox ButtonsGroupBox;
        private System.Windows.Forms.GroupBox DrawingGroupBox;
        private OpenTK.GLControl glControl1;

        #endregion
    }
}