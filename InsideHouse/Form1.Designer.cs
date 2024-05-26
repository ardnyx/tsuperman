namespace InsideHouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            wall_4 = new PictureBox();
            wall_2 = new PictureBox();
            wall_3 = new PictureBox();
            wall_1 = new PictureBox();
            protagonist = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)wall_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            SuspendLayout();
            // 
            // wall_4
            // 
            wall_4.BackColor = Color.Black;
            wall_4.Location = new Point(-7, 351);
            wall_4.Name = "wall_4";
            wall_4.Size = new Size(882, 180);
            wall_4.TabIndex = 0;
            wall_4.TabStop = false;
            wall_4.Tag = "Wall";
            // 
            // wall_2
            // 
            wall_2.BackColor = Color.Black;
            wall_2.Location = new Point(-7, -16);
            wall_2.Name = "wall_2";
            wall_2.Size = new Size(882, 166);
            wall_2.TabIndex = 1;
            wall_2.TabStop = false;
            wall_2.Tag = "Wall";
            // 
            // wall_3
            // 
            wall_3.BackColor = Color.Black;
            wall_3.Location = new Point(-51, 112);
            wall_3.Name = "wall_3";
            wall_3.Size = new Size(155, 274);
            wall_3.TabIndex = 2;
            wall_3.TabStop = false;
            wall_3.Tag = "Wall";
            // 
            // wall_1
            // 
            wall_1.BackColor = Color.Black;
            wall_1.Location = new Point(295, 45);
            wall_1.Name = "wall_1";
            wall_1.Size = new Size(580, 176);
            wall_1.TabIndex = 3;
            wall_1.TabStop = false;
            wall_1.Tag = "Wall";
            wall_1.Click += pictureBox4_Click;
            // 
            // protagonist
            // 
            protagonist.Image = Properties.Resources._51;
            protagonist.Location = new Point(774, 206);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(74, 130);
            protagonist.SizeMode = PictureBoxSizeMode.StretchImage;
            protagonist.TabIndex = 4;
            protagonist.TabStop = false;
            protagonist.Tag = "child";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 518);
            Controls.Add(protagonist);
            Controls.Add(wall_1);
            Controls.Add(wall_3);
            Controls.Add(wall_2);
            Controls.Add(wall_4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)wall_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox wall_4;
        private PictureBox wall_2;
        private PictureBox wall_3;
        private PictureBox wall_1;
        private PictureBox protagonist;
    }
}