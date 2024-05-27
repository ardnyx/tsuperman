namespace Post_Mission_1
{
    partial class PM1_LeavingTheHouse
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
            popUpPanel = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).BeginInit();
            popUpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // protagonist
            // 
            protagonist.BackgroundImage = Properties.Resources.child_1;
            protagonist.BackgroundImageLayout = ImageLayout.Stretch;
            protagonist.Location = new Point(766, 233);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(73, 136);
            protagonist.TabIndex = 35;
            protagonist.TabStop = false;
            // 
            // wall_4
            // 
            wall_4.BackColor = Color.Black;
            wall_4.Location = new Point(-19, -41);
            wall_4.Name = "wall_4";
            wall_4.Size = new Size(895, 210);
            wall_4.TabIndex = 34;
            wall_4.TabStop = false;
            // 
            // wall_3
            // 
            wall_3.BackColor = Color.Black;
            wall_3.Location = new Point(266, 11);
            wall_3.Name = "wall_3";
            wall_3.Size = new Size(610, 252);
            wall_3.TabIndex = 33;
            wall_3.TabStop = false;
            // 
            // wall_2
            // 
            wall_2.BackColor = Color.Black;
            wall_2.Location = new Point(-19, 397);
            wall_2.Name = "wall_2";
            wall_2.Size = new Size(883, 138);
            wall_2.TabIndex = 32;
            wall_2.TabStop = false;
            // 
            // wall_1
            // 
            wall_1.BackColor = Color.Black;
            wall_1.Location = new Point(-19, 44);
            wall_1.Name = "wall_1";
            wall_1.Size = new Size(117, 382);
            wall_1.TabIndex = 31;
            wall_1.TabStop = false;
            // 
            // popUpPanel
            // 
            popUpPanel.BackColor = Color.Khaki;
            popUpPanel.Controls.Add(label1);
            popUpPanel.Location = new Point(332, 418);
            popUpPanel.Name = "popUpPanel";
            popUpPanel.Size = new Size(200, 35);
            popUpPanel.TabIndex = 36;
            popUpPanel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 7);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Leave the House?";
            // 
            // PM1_LeavingTheHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 518);
            Controls.Add(popUpPanel);
            Controls.Add(protagonist);
            Controls.Add(wall_4);
            Controls.Add(wall_3);
            Controls.Add(wall_2);
            Controls.Add(wall_1);
            Name = "PM1_LeavingTheHouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PM1_LeavingTheHouse";
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).EndInit();
            popUpPanel.ResumeLayout(false);
            popUpPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist;
        private PictureBox wall_4;
        private PictureBox wall_3;
        private PictureBox wall_2;
        private PictureBox wall_1;
        private Panel popUpPanel;
        private Label label1;
    }
}