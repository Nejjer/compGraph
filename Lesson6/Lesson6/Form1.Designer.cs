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
            this.DrawingGroupBox = new System.Windows.Forms.GroupBox();
            this.glControl1 = new OpenTK.GLControl();
            this.DrawingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsGroupBox
            // 
            this.ButtonsGroupBox.Location = new System.Drawing.Point(6, 526);
            this.ButtonsGroupBox.Name = "ButtonsGroupBox";
            this.ButtonsGroupBox.Size = new System.Drawing.Size(457, 127);
            this.ButtonsGroupBox.TabIndex = 0;
            this.ButtonsGroupBox.TabStop = false;
            this.ButtonsGroupBox.Text = "Buttons";
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
            this.glControl1.BackColor = System.Drawing.Color.Silver;
            this.glControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.glControl1.Location = new System.Drawing.Point(6, 19);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(700, 471);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
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
            this.DrawingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox ButtonsGroupBox;
        private System.Windows.Forms.GroupBox DrawingGroupBox;
        private OpenTK.GLControl glControl1;

        #endregion
    }
}