namespace InsideHouse
{
    partial class OutsideHouse
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
            protagonist_house = new PictureBox();
            protagonist = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)protagonist_house).BeginInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            SuspendLayout();
            // 
            // protagonist_house
            // 
            protagonist_house.BackColor = Color.Transparent;
            protagonist_house.BackgroundImage = Properties.Resources.protagonist_house;
            protagonist_house.BackgroundImageLayout = ImageLayout.Stretch;
            protagonist_house.Location = new Point(42, 225);
            protagonist_house.Name = "protagonist_house";
            protagonist_house.Size = new Size(340, 293);
            protagonist_house.TabIndex = 7;
            protagonist_house.TabStop = false;
            protagonist_house.Tag = "Wall";
            // 
            // protagonist
            // 
            protagonist.BackColor = Color.Transparent;
            protagonist.Image = Properties.Resources._51;
            protagonist.Location = new Point(175, 388);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(74, 130);
            protagonist.SizeMode = PictureBoxSizeMode.StretchImage;
            protagonist.TabIndex = 11;
            protagonist.TabStop = false;
            protagonist.Tag = "child";
            // 
            // OutsideHouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.city_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(856, 518);
            Controls.Add(protagonist);
            Controls.Add(protagonist_house);
            DoubleBuffered = true;
            Name = "OutsideHouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OutsideHouse";
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)protagonist_house).EndInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist_house;
        private PictureBox protagonist;
    }
}