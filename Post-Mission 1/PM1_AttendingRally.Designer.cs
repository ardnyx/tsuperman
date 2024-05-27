namespace Post_Mission_1
{
    partial class PM1_AttendingRally
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
            wall_1 = new PictureBox();
            panel1 = new Panel();
            playerMsg = new Label();
            playerName = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // protagonist
            // 
            protagonist.BackgroundImage = Properties.Resources.child_1;
            protagonist.BackgroundImageLayout = ImageLayout.Stretch;
            protagonist.Location = new Point(771, 231);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(73, 136);
            protagonist.TabIndex = 45;
            protagonist.TabStop = false;
            // 
            // wall_4
            // 
            wall_4.BackColor = Color.Black;
            wall_4.Location = new Point(-19, -18);
            wall_4.Name = "wall_4";
            wall_4.Size = new Size(895, 189);
            wall_4.TabIndex = 44;
            wall_4.TabStop = false;
            // 
            // wall_1
            // 
            wall_1.BackColor = Color.Black;
            wall_1.Location = new Point(-19, 46);
            wall_1.Name = "wall_1";
            wall_1.Size = new Size(117, 382);
            wall_1.TabIndex = 41;
            wall_1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(playerMsg);
            panel1.Controls.Add(playerName);
            panel1.Location = new Point(-19, 384);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 163);
            panel1.TabIndex = 46;
            // 
            // playerMsg
            // 
            playerMsg.AutoSize = true;
            playerMsg.BackColor = Color.Transparent;
            playerMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerMsg.ForeColor = Color.White;
            playerMsg.Location = new Point(71, 59);
            playerMsg.Name = "playerMsg";
            playerMsg.Size = new Size(88, 28);
            playerMsg.TabIndex = 49;
            playerMsg.Text = "Message";
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.BackColor = Color.Transparent;
            playerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.White;
            playerName.Location = new Point(71, 28);
            playerName.Name = "playerName";
            playerName.Size = new Size(64, 28);
            playerName.TabIndex = 48;
            playerName.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(-19, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(999, 221);
            panel2.TabIndex = 47;
            // 
            // PM1_AttendingRally
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 518);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(protagonist);
            Controls.Add(wall_4);
            Controls.Add(wall_1);
            Name = "PM1_AttendingRally";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PM1_AttendingRally";
            Load += PM1_AttendingRally_Load;
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist;
        private PictureBox wall_4;
        private PictureBox wall_1;
        private Panel panel1;
        private Panel panel2;
        private Label playerMsg;
        private Label playerName;
    }
}