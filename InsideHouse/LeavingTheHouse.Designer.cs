namespace InsideHouse
{
    partial class LeavingTheHouse
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
            wall_1 = new PictureBox();
            wall_3 = new PictureBox();
            wall_2 = new PictureBox();
            wall_4 = new PictureBox();
            popUpPanel = new Panel();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).BeginInit();
            popUpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // protagonist
            // 
            protagonist.Image = Properties.Resources._51;
            protagonist.Location = new Point(770, 201);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(74, 130);
            protagonist.SizeMode = PictureBoxSizeMode.StretchImage;
            protagonist.TabIndex = 9;
            protagonist.TabStop = false;
            protagonist.Tag = "child";
            // 
            // wall_1
            // 
            wall_1.BackColor = Color.Black;
            wall_1.Location = new Point(311, 47);
            wall_1.Name = "wall_1";
            wall_1.Size = new Size(580, 176);
            wall_1.TabIndex = 8;
            wall_1.TabStop = false;
            wall_1.Tag = "Wall";
            // 
            // wall_3
            // 
            wall_3.BackColor = Color.Black;
            wall_3.Location = new Point(-35, 114);
            wall_3.Name = "wall_3";
            wall_3.Size = new Size(155, 274);
            wall_3.TabIndex = 7;
            wall_3.TabStop = false;
            wall_3.Tag = "Wall";
            // 
            // wall_2
            // 
            wall_2.BackColor = Color.Black;
            wall_2.Location = new Point(9, -14);
            wall_2.Name = "wall_2";
            wall_2.Size = new Size(882, 166);
            wall_2.TabIndex = 6;
            wall_2.TabStop = false;
            wall_2.Tag = "Wall";
            // 
            // wall_4
            // 
            wall_4.BackColor = Color.Black;
            wall_4.Location = new Point(9, 353);
            wall_4.Name = "wall_4";
            wall_4.Size = new Size(882, 180);
            wall_4.TabIndex = 5;
            wall_4.TabStop = false;
            wall_4.Tag = "Wall";
            // 
            // popUpPanel
            // 
            popUpPanel.BackColor = Color.Gray;
            popUpPanel.Controls.Add(label);
            popUpPanel.Location = new Point(302, 407);
            popUpPanel.Name = "popUpPanel";
            popUpPanel.Size = new Size(256, 38);
            popUpPanel.TabIndex = 20;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.White;
            label.Location = new Point(62, 8);
            label.Name = "label";
            label.Size = new Size(131, 21);
            label.TabIndex = 0;
            label.Text = "Leave the House?";
            // 
            // LeavingTheHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 518);
            Controls.Add(popUpPanel);
            Controls.Add(protagonist);
            Controls.Add(wall_1);
            Controls.Add(wall_3);
            Controls.Add(wall_2);
            Controls.Add(wall_4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LeavingTheHouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LeavingTheHouse";
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).EndInit();
            popUpPanel.ResumeLayout(false);
            popUpPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist;
        private PictureBox wall_1;
        private PictureBox wall_3;
        private PictureBox wall_2;
        private PictureBox wall_4;
        private Panel popUpPanel;
        private Label label;
    }
}