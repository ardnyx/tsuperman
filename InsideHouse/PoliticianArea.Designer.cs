namespace InsideHouse
{
    partial class PoliticianArea
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
            pictureBox1 = new PictureBox();
            popUpPanel = new Panel();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            popUpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // protagonist
            // 
            protagonist.BackColor = Color.Transparent;
            protagonist.Image = Properties.Resources._51;
            protagonist.Location = new Point(12, 346);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(74, 130);
            protagonist.SizeMode = PictureBoxSizeMode.StretchImage;
            protagonist.TabIndex = 12;
            protagonist.TabStop = false;
            protagonist.Tag = "child";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.local_politician;
            pictureBox1.Location = new Point(682, 325);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "child";
            // 
            // popUpPanel
            // 
            popUpPanel.BackColor = Color.Gray;
            popUpPanel.Controls.Add(label);
            popUpPanel.Location = new Point(292, 468);
            popUpPanel.Name = "popUpPanel";
            popUpPanel.Size = new Size(256, 38);
            popUpPanel.TabIndex = 20;
            popUpPanel.Visible = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.White;
            label.Location = new Point(22, 8);
            label.Name = "label";
            label.Size = new Size(209, 21);
            label.TabIndex = 0;
            label.Text = "Press 'Enter' to talk to Mayor";
            // 
            // PoliticianArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.city_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 518);
            Controls.Add(popUpPanel);
            Controls.Add(pictureBox1);
            Controls.Add(protagonist);
            DoubleBuffered = true;
            Name = "PoliticianArea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PoliticianArea";
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            popUpPanel.ResumeLayout(false);
            popUpPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist;
        private PictureBox pictureBox1;
        private Panel popUpPanel;
        private Label label;
    }
}