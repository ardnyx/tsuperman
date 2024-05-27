namespace Post_Mission_1
{
    partial class PM1_EnteringTheHouse
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
            protagonist = new PictureBox();
            wall_4 = new PictureBox();
            wall_3 = new PictureBox();
            wall_2 = new PictureBox();
            wall_1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).BeginInit();
            SuspendLayout();
            // 
            // protagonist
            // 
            protagonist.BackgroundImage = Properties.Resources.child_1;
            protagonist.BackgroundImageLayout = ImageLayout.Stretch;
            protagonist.Location = new Point(148, 226);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(73, 136);
            protagonist.TabIndex = 40;
            protagonist.TabStop = false;
            // 
            // wall_4
            // 
            wall_4.BackColor = Color.Black;
            wall_4.Location = new Point(-19, -8);
            wall_4.Name = "wall_4";
            wall_4.Size = new Size(895, 189);
            wall_4.TabIndex = 39;
            wall_4.TabStop = false;
            // 
            // wall_3
            // 
            wall_3.BackColor = Color.Black;
            wall_3.Location = new Point(266, 23);
            wall_3.Name = "wall_3";
            wall_3.Size = new Size(610, 252);
            wall_3.TabIndex = 38;
            wall_3.TabStop = false;
            // 
            // wall_2
            // 
            wall_2.BackColor = Color.Black;
            wall_2.Location = new Point(-19, 409);
            wall_2.Name = "wall_2";
            wall_2.Size = new Size(883, 138);
            wall_2.TabIndex = 37;
            wall_2.TabStop = false;
            // 
            // wall_1
            // 
            wall_1.BackColor = Color.Black;
            wall_1.Location = new Point(-19, 56);
            wall_1.Name = "wall_1";
            wall_1.Size = new Size(117, 382);
            wall_1.TabIndex = 36;
            wall_1.TabStop = false;
            // 
            // PM1_EnteringTheHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 518);
            Controls.Add(protagonist);
            Controls.Add(wall_4);
            Controls.Add(wall_3);
            Controls.Add(wall_2);
            Controls.Add(wall_1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PM1_EnteringTheHouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PM1_EnteringTheHouse";
            Load += PM1_EnteringTheHouse_Load;
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist;
        private PictureBox wall_4;
        private PictureBox wall_3;
        private PictureBox wall_2;
        private PictureBox wall_1;
    }
}