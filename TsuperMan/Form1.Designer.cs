namespace TsuperMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            StartBtn = new Button();
            QuitBtn = new Button();
            Form1Pnl = new Panel();
            Form1Pnl.SuspendLayout();
            SuspendLayout();
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.Transparent;
            StartBtn.BackgroundImageLayout = ImageLayout.Zoom;
            StartBtn.FlatAppearance.BorderSize = 0;
            StartBtn.FlatAppearance.MouseDownBackColor = Color.RosyBrown;
            StartBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            StartBtn.FlatStyle = FlatStyle.Flat;
            StartBtn.Image = (Image)resources.GetObject("StartBtn.Image");
            StartBtn.Location = new Point(575, 344);
            StartBtn.Margin = new Padding(3, 2, 3, 2);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(208, 50);
            StartBtn.TabIndex = 1;
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += button1_Click;
            // 
            // QuitBtn
            // 
            QuitBtn.BackColor = Color.Transparent;
            QuitBtn.FlatAppearance.BorderSize = 0;
            QuitBtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            QuitBtn.FlatAppearance.MouseOverBackColor = Color.RosyBrown;
            QuitBtn.FlatStyle = FlatStyle.Flat;
            QuitBtn.Image = Properties.Resources.Untitled_design__8__removebg_preview;
            QuitBtn.Location = new Point(584, 389);
            QuitBtn.Margin = new Padding(3, 2, 3, 2);
            QuitBtn.Name = "QuitBtn";
            QuitBtn.Size = new Size(194, 45);
            QuitBtn.TabIndex = 2;
            QuitBtn.UseVisualStyleBackColor = false;
            // 
            // Form1Pnl
            // 
            Form1Pnl.BackgroundImage = (Image)resources.GetObject("Form1Pnl.BackgroundImage");
            Form1Pnl.BackgroundImageLayout = ImageLayout.Stretch;
            Form1Pnl.Controls.Add(StartBtn);
            Form1Pnl.Controls.Add(QuitBtn);
            Form1Pnl.Location = new Point(0, 0);
            Form1Pnl.Margin = new Padding(3, 2, 3, 2);
            Form1Pnl.Name = "Form1Pnl";
            Form1Pnl.Size = new Size(1340, 589);
            Form1Pnl.TabIndex = 3;
            Form1Pnl.Paint += Form1Pnl_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 585);
            Controls.Add(Form1Pnl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Form1Pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button StartBtn;
        private Button QuitBtn;
        private Panel Form1Pnl;
    }
}