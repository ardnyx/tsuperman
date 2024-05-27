namespace Post_Mission_1
{
    partial class PM1_LivingRoom_Part2
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
            window = new PictureBox();
            wall_7 = new PictureBox();
            wall_6 = new PictureBox();
            wall_5 = new PictureBox();
            wall_4 = new PictureBox();
            wall_3 = new PictureBox();
            wall_2 = new PictureBox();
            wall_8 = new PictureBox();
            wall_1 = new PictureBox();
            popUpPanel = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)window).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).BeginInit();
            popUpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // protagonist
            // 
            protagonist.BackgroundImage = Properties.Resources.child_1;
            protagonist.BackgroundImageLayout = ImageLayout.Stretch;
            protagonist.Location = new Point(2, 206);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(73, 136);
            protagonist.TabIndex = 40;
            protagonist.TabStop = false;
            // 
            // window
            // 
            window.BackColor = Color.Brown;
            window.Location = new Point(153, 426);
            window.Name = "window";
            window.Size = new Size(184, 31);
            window.TabIndex = 39;
            window.TabStop = false;
            // 
            // wall_7
            // 
            wall_7.BackColor = Color.Black;
            wall_7.Location = new Point(-11, 32);
            wall_7.Name = "wall_7";
            wall_7.Size = new Size(96, 202);
            wall_7.TabIndex = 38;
            wall_7.TabStop = false;
            // 
            // wall_6
            // 
            wall_6.BackColor = Color.Black;
            wall_6.Location = new Point(-30, -41);
            wall_6.Name = "wall_6";
            wall_6.Size = new Size(219, 115);
            wall_6.TabIndex = 37;
            wall_6.TabStop = false;
            // 
            // wall_5
            // 
            wall_5.BackColor = Color.Black;
            wall_5.Location = new Point(314, -70);
            wall_5.Name = "wall_5";
            wall_5.Size = new Size(185, 144);
            wall_5.TabIndex = 36;
            wall_5.TabStop = false;
            // 
            // wall_4
            // 
            wall_4.BackColor = Color.Black;
            wall_4.Location = new Point(633, -70);
            wall_4.Name = "wall_4";
            wall_4.Size = new Size(231, 144);
            wall_4.TabIndex = 35;
            wall_4.TabStop = false;
            // 
            // wall_3
            // 
            wall_3.BackColor = Color.Black;
            wall_3.Location = new Point(773, -18);
            wall_3.Name = "wall_3";
            wall_3.Size = new Size(111, 252);
            wall_3.TabIndex = 34;
            wall_3.TabStop = false;
            // 
            // wall_2
            // 
            wall_2.BackColor = Color.Black;
            wall_2.Location = new Point(773, 348);
            wall_2.Name = "wall_2";
            wall_2.Size = new Size(99, 142);
            wall_2.TabIndex = 33;
            wall_2.TabStop = false;
            // 
            // wall_8
            // 
            wall_8.BackColor = Color.Black;
            wall_8.Location = new Point(-11, 348);
            wall_8.Name = "wall_8";
            wall_8.Size = new Size(96, 109);
            wall_8.TabIndex = 32;
            wall_8.TabStop = false;
            // 
            // wall_1
            // 
            wall_1.BackColor = Color.Black;
            wall_1.Location = new Point(-11, 448);
            wall_1.Name = "wall_1";
            wall_1.Size = new Size(883, 83);
            wall_1.TabIndex = 31;
            wall_1.TabStop = false;
            // 
            // popUpPanel
            // 
            popUpPanel.BackColor = Color.Khaki;
            popUpPanel.Controls.Add(label1);
            popUpPanel.Location = new Point(289, 471);
            popUpPanel.Name = "popUpPanel";
            popUpPanel.Size = new Size(285, 35);
            popUpPanel.TabIndex = 41;
            popUpPanel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 7);
            label1.Name = "label1";
            label1.Size = new Size(232, 21);
            label1.TabIndex = 0;
            label1.Text = "Press 'Enter'  to Check Windows";
            // 
            // PM1_LivingRoom_Part2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 518);
            Controls.Add(popUpPanel);
            Controls.Add(protagonist);
            Controls.Add(window);
            Controls.Add(wall_7);
            Controls.Add(wall_6);
            Controls.Add(wall_5);
            Controls.Add(wall_4);
            Controls.Add(wall_3);
            Controls.Add(wall_2);
            Controls.Add(wall_8);
            Controls.Add(wall_1);
            Name = "PM1_LivingRoom_Part2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PM1_LivingRoom_Part2";
            Load += PM1_LivingRoom_Part2_Load;
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)window).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_7).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_8).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).EndInit();
            popUpPanel.ResumeLayout(false);
            popUpPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist;
        private PictureBox window;
        private PictureBox wall_7;
        private PictureBox wall_6;
        private PictureBox wall_5;
        private PictureBox wall_4;
        private PictureBox wall_3;
        private PictureBox wall_2;
        private PictureBox wall_8;
        private PictureBox wall_1;
        private Panel popUpPanel;
        private Label label1;
    }
}