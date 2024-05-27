namespace Post_Mission_1
{
    partial class PM1_Cutscene
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            playerMsg = new Label();
            playerName = new Label();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(playerMsg);
            panel1.Controls.Add(playerName);
            panel1.Location = new Point(-20, 366);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 183);
            panel1.TabIndex = 1;
            // 
            // playerMsg
            // 
            playerMsg.AutoSize = true;
            playerMsg.BackColor = Color.Transparent;
            playerMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerMsg.ForeColor = Color.White;
            playerMsg.Location = new Point(77, 83);
            playerMsg.Name = "playerMsg";
            playerMsg.Size = new Size(88, 28);
            playerMsg.TabIndex = 51;
            playerMsg.Text = "Message";
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.BackColor = Color.Transparent;
            playerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.White;
            playerName.Location = new Point(77, 52);
            playerName.Name = "playerName";
            playerName.Size = new Size(64, 28);
            playerName.TabIndex = 50;
            playerName.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(-46, -20);
            panel2.Name = "panel2";
            panel2.Size = new Size(931, 158);
            panel2.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 800;
            timer1.Tick += timer1_Tick;
            // 
            // PM1_Cutscene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.rally_bg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 518);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PM1_Cutscene";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PM1_Cutscene";
            Load += PM1_Cutscene_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label playerMsg;
        private Label playerName;
        private System.Windows.Forms.Timer timer1;
    }
}