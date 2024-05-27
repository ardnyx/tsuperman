namespace InsideHouse
{
    partial class PA_Dialogue_Section_1
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
            politician = new PictureBox();
            protagonist = new PictureBox();
            panel1 = new Panel();
            playerMsg = new Label();
            playerName = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)politician).BeginInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // politician
            // 
            politician.BackColor = Color.Transparent;
            politician.Image = Properties.Resources.local_politician;
            politician.Location = new Point(636, 255);
            politician.Name = "politician";
            politician.Size = new Size(137, 214);
            politician.SizeMode = PictureBoxSizeMode.StretchImage;
            politician.TabIndex = 15;
            politician.TabStop = false;
            politician.Tag = "child";
            // 
            // protagonist
            // 
            protagonist.BackColor = Color.Transparent;
            protagonist.Image = Properties.Resources._51;
            protagonist.Location = new Point(559, 299);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(100, 170);
            protagonist.SizeMode = PictureBoxSizeMode.StretchImage;
            protagonist.TabIndex = 17;
            protagonist.TabStop = false;
            protagonist.Tag = "child";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(playerMsg);
            panel1.Controls.Add(playerName);
            panel1.Location = new Point(-13, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 235);
            panel1.TabIndex = 24;
            // 
            // playerMsg
            // 
            playerMsg.AutoSize = true;
            playerMsg.BackColor = Color.Transparent;
            playerMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerMsg.ForeColor = Color.White;
            playerMsg.Location = new Point(73, 119);
            playerMsg.Name = "playerMsg";
            playerMsg.Size = new Size(88, 28);
            playerMsg.TabIndex = 1;
            playerMsg.Tag = "";
            playerMsg.Text = "Message";
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.BackColor = Color.Transparent;
            playerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.White;
            playerName.Location = new Point(73, 91);
            playerName.Name = "playerName";
            playerName.Size = new Size(65, 28);
            playerName.TabIndex = 0;
            playerName.Tag = "";
            playerName.Text = "Player";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(-13, 447);
            panel2.Name = "panel2";
            panel2.Size = new Size(877, 85);
            panel2.TabIndex = 25;
            // 
            // PA_Dialogue_Section_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.city_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 518);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(protagonist);
            Controls.Add(politician);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PA_Dialogue_Section_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PA_Dialogue_Section_1";
            Load += PA_Dialogue_Section_1_Load;
            ((System.ComponentModel.ISupportInitialize)politician).EndInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox politician;
        private PictureBox protagonist;
        private Panel panel1;
        private Label playerMsg;
        private Label playerName;
        private Panel panel2;
    }
}