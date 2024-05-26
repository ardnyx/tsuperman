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
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // PoliticianArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.city_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 518);
            Controls.Add(pictureBox1);
            Controls.Add(protagonist);
            DoubleBuffered = true;
            Name = "PoliticianArea";
            Text = "PoliticianArea";
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist;
        private PictureBox pictureBox1;
    }
}