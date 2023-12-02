namespace Lesson5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.xText = new System.Windows.Forms.TextBox();
            this.yText = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colorPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 248);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(438, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(393, 242);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(8, 303);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(73, 20);
            this.xText.TabIndex = 2;
            // 
            // yText
            // 
            this.yText.Location = new System.Drawing.Point(100, 303);
            this.yText.Name = "yText";
            this.yText.Size = new System.Drawing.Size(73, 20);
            this.yText.TabIndex = 3;
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(8, 282);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(58, 18);
            this.xLabel.TabIndex = 4;
            this.xLabel.Text = "X";
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(100, 282);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(58, 18);
            this.Y.TabIndex = 5;
            this.Y.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorPicture
            // 
            this.colorPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPicture.Location = new System.Drawing.Point(282, 303);
            this.colorPicture.Name = "colorPicture";
            this.colorPicture.Size = new System.Drawing.Size(20, 20);
            this.colorPicture.TabIndex = 7;
            this.colorPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 659);
            this.Controls.Add(this.colorPicture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.yText);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox colorPicture;

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.TextBox yText;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}