namespace InsideHouse
{
    partial class LR_Dialogue_Section_1
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
            father = new PictureBox();
            diamondPictureBox1 = new DiamondPictureBox();
            table = new RoundPictureBox();
            panel1 = new Panel();
            playerMsg = new Label();
            playerName = new Label();
            panel2 = new Panel();
            wall_1 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)protagonist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)father).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diamondPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wall_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // protagonist
            // 
            protagonist.Image = Properties.Resources._51;
            protagonist.Location = new Point(205, 198);
            protagonist.Name = "protagonist";
            protagonist.Size = new Size(74, 130);
            protagonist.SizeMode = PictureBoxSizeMode.StretchImage;
            protagonist.TabIndex = 20;
            protagonist.TabStop = false;
            protagonist.Tag = "child";
            // 
            // father
            // 
            father.Image = Properties.Resources._71;
            father.Location = new Point(301, 159);
            father.Name = "father";
            father.Size = new Size(95, 169);
            father.SizeMode = PictureBoxSizeMode.StretchImage;
            father.TabIndex = 19;
            father.TabStop = false;
            // 
            // diamondPictureBox1
            // 
            diamondPictureBox1.BackColor = Color.Khaki;
            diamondPictureBox1.Location = new Point(496, 182);
            diamondPictureBox1.Name = "diamondPictureBox1";
            diamondPictureBox1.Size = new Size(57, 53);
            diamondPictureBox1.TabIndex = 22;
            diamondPictureBox1.TabStop = false;
            // 
            // table
            // 
            table.BackColor = Color.Maroon;
            table.Location = new Point(474, 148);
            table.Name = "table";
            table.Size = new Size(170, 163);
            table.TabIndex = 21;
            table.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(playerMsg);
            panel1.Controls.Add(playerName);
            panel1.Location = new Point(-31, 360);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 180);
            panel1.TabIndex = 23;
            // 
            // playerMsg
            // 
            playerMsg.AutoSize = true;
            playerMsg.BackColor = Color.Transparent;
            playerMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerMsg.ForeColor = Color.White;
            playerMsg.Location = new Point(79, 53);
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
            playerName.Location = new Point(79, 25);
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
            panel2.Location = new Point(-63, -6);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 134);
            panel2.TabIndex = 24;
            // 
            // wall_1
            // 
            wall_1.BackColor = Color.Black;
            wall_1.Location = new Point(-7, 12);
            wall_1.Name = "wall_1";
            wall_1.Size = new Size(134, 279);
            wall_1.TabIndex = 26;
            wall_1.TabStop = false;
            wall_1.Tag = "Wall";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(750, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 223);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "Wall";
            // 
            // LR_Dialogue_Section_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 518);
            Controls.Add(pictureBox1);
            Controls.Add(wall_1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(diamondPictureBox1);
            Controls.Add(table);
            Controls.Add(protagonist);
            Controls.Add(father);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LR_Dialogue_Section_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LR_Dialogue_Section_1";
            Load += LR_Dialogue_Section_1_Load;
            ((System.ComponentModel.ISupportInitialize)protagonist).EndInit();
            ((System.ComponentModel.ISupportInitialize)father).EndInit();
            ((System.ComponentModel.ISupportInitialize)diamondPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wall_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox protagonist;
        private PictureBox father;
        private DiamondPictureBox diamondPictureBox1;
        private RoundPictureBox table;
        private Panel panel1;
        private Panel panel2;
        private PictureBox wall_1;
        private PictureBox pictureBox1;
        private Label playerName;
        private Label playerMsg;
    }
}