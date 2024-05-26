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
            flooring = new PictureBox();
            protagonist = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)protagonist_house).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flooring).BeginInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            SuspendLayout();
            // 
            // protagonist_house
            // 
            protagonist_house.BackColor = Color.Transparent;
            protagonist_house.BackgroundImage = Properties.Resources.protagonist_house;
            protagonist_house.BackgroundImageLayout = ImageLayout.Stretch;
            protagonist_house.Location = new Point(78, 154);
            protagonist_house.Name = "protagonist_house";
            protagonist_house.Size = new Size(340, 293);
            protagonist_house.TabIndex = 7;
            protagonist_house.TabStop = false;
            protagonist_house.Tag = "Wall";
            // 
            // flooring
            // 
            flooring.BackColor = Color.White;
            flooring.Location = new Point(-5, 440);
            flooring.Name = "flooring";
            flooring.Size = new Size(882, 88);
            flooring.TabIndex = 10;
            flooring.TabStop = false;
            flooring.Tag = "Wall";
            // 
            // protagonist
            // 
            protagonist.BackColor = Color.White;
            protagonist.Image = Properties.Resources._51;
            protagonist.Location = new Point(206, 329);
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
            ClientSize = new Size(856, 518);
            Controls.Add(protagonist);
            Controls.Add(flooring);
            Controls.Add(protagonist_house);
            Name = "OutsideHouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OutsideHouse";
            KeyDown += keyIsDown;
            KeyUp += keyIsUp;
            ((System.ComponentModel.ISupportInitialize)protagonist_house).EndInit();
            ((System.ComponentModel.ISupportInitialize)flooring).EndInit();
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist_house;
        private PictureBox flooring;
        private PictureBox protagonist;
    }
}