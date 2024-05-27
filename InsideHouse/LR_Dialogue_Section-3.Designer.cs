namespace InsideHouse
{
    partial class LR_Dialogue_Section_3
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
            wall_3 = new PictureBox();
            wall_2 = new PictureBox();
            wall_4 = new PictureBox();
            playerMsg = new Label();
            playerName = new Label();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).BeginInit();
            SuspendLayout();
            // 
            // protagonist
            // 
            protagonist.Image = Properties.Resources._51;
            protagonist.Location = new Point(159, 183);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(74, 130);
            protagonist.SizeMode = PictureBoxSizeMode.StretchImage;
            protagonist.TabIndex = 9;
            protagonist.TabStop = false;
            protagonist.Tag = "child";
            // 
            // wall_3
            // 
            wall_3.BackColor = Color.Black;
            wall_3.Location = new Point(-57, 113);
            wall_3.Name = "wall_3";
            wall_3.Size = new Size(155, 274);
            wall_3.TabIndex = 7;
            wall_3.TabStop = false;
            wall_3.Tag = "Wall";
            // 
            // wall_2
            // 
            wall_2.BackColor = Color.Black;
            wall_2.BorderStyle = BorderStyle.Fixed3D;
            wall_2.Location = new Point(-13, -15);
            wall_2.Name = "wall_2";
            wall_2.Size = new Size(882, 166);
            wall_2.TabIndex = 6;
            wall_2.TabStop = false;
            wall_2.Tag = "Wall";
            // 
            // wall_4
            // 
            wall_4.BackColor = Color.Black;
            wall_4.BorderStyle = BorderStyle.Fixed3D;
            wall_4.Location = new Point(-13, 352);
            wall_4.Name = "wall_4";
            wall_4.Size = new Size(882, 180);
            wall_4.TabIndex = 5;
            wall_4.TabStop = false;
            wall_4.Tag = "Wall";
            // 
            // playerMsg
            // 
            playerMsg.AutoSize = true;
            playerMsg.BackColor = Color.Black;
            playerMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerMsg.ForeColor = Color.White;
            playerMsg.Location = new Point(82, 418);
            playerMsg.Name = "playerMsg";
            playerMsg.Size = new Size(88, 28);
            playerMsg.TabIndex = 11;
            playerMsg.Tag = "";
            playerMsg.Text = "Message";
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.BackColor = Color.Black;
            playerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.White;
            playerName.Location = new Point(82, 390);
            playerName.Name = "playerName";
            playerName.Size = new Size(65, 28);
            playerName.TabIndex = 10;
            playerName.Tag = "";
            playerName.Text = "Player";
            // 
            // LR_Dialogue_Section_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 518);
            Controls.Add(playerMsg);
            Controls.Add(playerName);
            Controls.Add(protagonist);
            Controls.Add(wall_3);
            Controls.Add(wall_2);
            Controls.Add(wall_4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LR_Dialogue_Section_3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LR_Dialogue_Section_3";
            Load += LR_Dialogue_Section_3_Load;
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall_4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox protagonist;
        private PictureBox wall_3;
        private PictureBox wall_2;
        private PictureBox wall_4;
        private Label playerMsg;
        private Label playerName;
    }
}