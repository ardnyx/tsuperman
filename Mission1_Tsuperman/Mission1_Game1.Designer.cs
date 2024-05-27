namespace Mission1_Tsuperman
{
    partial class Mission1_Game1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mission1_Game1));
            panel1 = new Panel();
            AI1 = new PictureBox();
            player = new PictureBox();
            AI3 = new PictureBox();
            AI2 = new PictureBox();
            Obj2 = new PictureBox();
            Obj1 = new PictureBox();
            gameScore = new Label();
            btnRestart = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Obj2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Obj1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(AI1);
            panel1.Controls.Add(player);
            panel1.Controls.Add(AI3);
            panel1.Controls.Add(AI2);
            panel1.Controls.Add(Obj2);
            panel1.Controls.Add(Obj1);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 450);
            panel1.TabIndex = 1;
            // 
            // AI1
            // 
            AI1.BackColor = Color.Transparent;
            AI1.Image = Properties.Resources.ambulance;
            AI1.Location = new Point(698, 146);
            AI1.Name = "AI1";
            AI1.Size = new Size(70, 36);
            AI1.SizeMode = PictureBoxSizeMode.StretchImage;
            AI1.TabIndex = 6;
            AI1.TabStop = false;
            AI1.Tag = "carUpper";
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources._5__1_;
            player.Location = new Point(3, 315);
            player.Name = "player";
            player.Size = new Size(39, 59);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 5;
            player.TabStop = false;
            // 
            // AI3
            // 
            AI3.BackColor = Color.Transparent;
            AI3.Image = Properties.Resources.carGrey;
            AI3.Location = new Point(689, 366);
            AI3.Name = "AI3";
            AI3.Size = new Size(79, 37);
            AI3.SizeMode = PictureBoxSizeMode.StretchImage;
            AI3.TabIndex = 4;
            AI3.TabStop = false;
            AI3.Tag = "carLower";
            // 
            // AI2
            // 
            AI2.BackColor = Color.Transparent;
            AI2.Image = Properties.Resources.carGreen;
            AI2.Location = new Point(698, 236);
            AI2.Name = "AI2";
            AI2.Size = new Size(70, 36);
            AI2.SizeMode = PictureBoxSizeMode.StretchImage;
            AI2.TabIndex = 3;
            AI2.TabStop = false;
            AI2.Tag = "carMiddle";
            // 
            // Obj2
            // 
            Obj2.BackColor = Color.Transparent;
            Obj2.Image = Properties.Resources._15;
            Obj2.Location = new Point(310, 62);
            Obj2.Name = "Obj2";
            Obj2.Size = new Size(38, 55);
            Obj2.SizeMode = PictureBoxSizeMode.StretchImage;
            Obj2.TabIndex = 1;
            Obj2.TabStop = false;
            // 
            // Obj1
            // 
            Obj1.BackColor = Color.Transparent;
            Obj1.Image = Properties.Resources._14;
            Obj1.Location = new Point(90, 187);
            Obj1.Name = "Obj1";
            Obj1.Size = new Size(40, 55);
            Obj1.SizeMode = PictureBoxSizeMode.StretchImage;
            Obj1.TabIndex = 0;
            Obj1.TabStop = false;
            // 
            // gameScore
            // 
            gameScore.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gameScore.AutoSize = true;
            gameScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gameScore.ForeColor = Color.White;
            gameScore.Location = new Point(15, 473);
            gameScore.Name = "gameScore";
            gameScore.Size = new Size(65, 21);
            gameScore.TabIndex = 2;
            gameScore.Text = "Score: 0";
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRestart.BackColor = Color.White;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Location = new Point(683, 471);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(104, 28);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Mission1_Game1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 19, 19);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnRestart);
            Controls.Add(gameScore);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Mission1_Game1";
            Size = new Size(800, 520);
            Load += Mission1_Game1_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI3).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Obj2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Obj1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label gameScore;
        private Button btnRestart;
        private PictureBox AI3;
        private PictureBox AI2;
        private PictureBox Obj2;
        private PictureBox Obj1;
        private PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox AI1;
    }
}
