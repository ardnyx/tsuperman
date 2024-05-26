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
            wall_2 = new PictureBox();
            politician = new PictureBox();
            protagonist = new PictureBox();
            pictureBox4 = new PictureBox();
            playerMsg = new Label();
            playerName = new Label();
            ((System.ComponentModel.ISupportInitialize)wall_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)politician).BeginInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // wall_2
            // 
            wall_2.BackColor = Color.Black;
            wall_2.BorderStyle = BorderStyle.Fixed3D;
            wall_2.Location = new Point(-13, -14);
            wall_2.Name = "wall_2";
            wall_2.Size = new Size(882, 233);
            wall_2.TabIndex = 8;
            wall_2.TabStop = false;
            wall_2.Tag = "Wall";
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
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Black;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(-13, 446);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(882, 78);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "Wall";
            // 
            // playerMsg
            // 
            playerMsg.AutoSize = true;
            playerMsg.BackColor = Color.Black;
            playerMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerMsg.ForeColor = Color.White;
            playerMsg.Location = new Point(46, 102);
            playerMsg.Name = "playerMsg";
            playerMsg.Size = new Size(88, 28);
            playerMsg.TabIndex = 20;
            playerMsg.Tag = "";
            playerMsg.Text = "Message";
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.BackColor = Color.Black;
            playerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.White;
            playerName.Location = new Point(46, 74);
            playerName.Name = "playerName";
            playerName.Size = new Size(65, 28);
            playerName.TabIndex = 19;
            playerName.Tag = "";
            playerName.Text = "Player";
            // 
            // PA_Dialogue_Section_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.city_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 518);
            Controls.Add(playerMsg);
            Controls.Add(playerName);
            Controls.Add(pictureBox4);
            Controls.Add(protagonist);
            Controls.Add(politician);
            Controls.Add(wall_2);
            DoubleBuffered = true;
            Name = "PA_Dialogue_Section_1";
            Text = "PA_Dialogue_Section_1";
            Load += PA_Dialogue_Section_1_Load;
            ((System.ComponentModel.ISupportInitialize)wall_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)politician).EndInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox wall_2;
        private PictureBox politician;
        private PictureBox protagonist;
        private PictureBox pictureBox4;
        private Label playerMsg;
        private Label playerName;
    }
}