namespace Post_Mission_2
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            playerMsg = new Label();
            playerName = new Label();
            panel2 = new Panel();
            backgroundChanger = new System.Windows.Forms.Timer(components);
            beforeTextAppears = new System.Windows.Forms.Timer(components);
            endLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(playerMsg);
            panel1.Controls.Add(playerName);
            panel1.Location = new Point(-17, 374);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 178);
            panel1.TabIndex = 0;
            // 
            // playerMsg
            // 
            playerMsg.AutoSize = true;
            playerMsg.BackColor = Color.Transparent;
            playerMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerMsg.ForeColor = Color.White;
            playerMsg.Location = new Point(64, 62);
            playerMsg.Name = "playerMsg";
            playerMsg.Size = new Size(50, 28);
            playerMsg.TabIndex = 1;
            playerMsg.Text = "Msg";
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.BackColor = Color.Transparent;
            playerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.White;
            playerName.Location = new Point(64, 34);
            playerName.Name = "playerName";
            playerName.Size = new Size(127, 28);
            playerName.TabIndex = 0;
            playerName.Text = "News Anchor";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(-17, -15);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 146);
            panel2.TabIndex = 1;
            // 
            // backgroundChanger
            // 
            backgroundChanger.Enabled = true;
            backgroundChanger.Interval = 500;
            backgroundChanger.Tick += backgroundChanger_Tick;
            // 
            // beforeTextAppears
            // 
            beforeTextAppears.Enabled = true;
            beforeTextAppears.Interval = 1000;
            beforeTextAppears.Tick += beforeTextAppears_Tick;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.BackColor = Color.Transparent;
            endLabel.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            endLabel.ForeColor = Color.White;
            endLabel.Location = new Point(273, 236);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(0, 42);
            endLabel.TabIndex = 2;
            endLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.news1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(856, 518);
            Controls.Add(endLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label playerMsg;
        private Label playerName;
        private Panel panel2;
        private System.Windows.Forms.Timer backgroundChanger;
        private System.Windows.Forms.Timer beforeTextAppears;
        private Label endLabel;
    }
}