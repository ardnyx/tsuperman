namespace Mission1_Tsuperman
{
    partial class Mission1_Flyers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mission1_Flyers));
            panel1 = new Panel();
            AI3 = new PictureBox();
            AI2 = new PictureBox();
            AI1 = new PictureBox();
            obj2 = new PictureBox();
            obj1 = new PictureBox();
            player = new PictureBox();
            txtScore = new Label();
            btnRestart = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            txtObj = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AI3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obj2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obj1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(AI3);
            panel1.Controls.Add(AI2);
            panel1.Controls.Add(AI1);
            panel1.Controls.Add(obj2);
            panel1.Controls.Add(obj1);
            panel1.Controls.Add(player);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 440);
            panel1.TabIndex = 0;
            // 
            // AI3
            // 
            AI3.BackColor = Color.Transparent;
            AI3.Image = Properties.Resources.CarRed;
            AI3.Location = new Point(731, 361);
            AI3.Name = "AI3";
            AI3.Size = new Size(53, 25);
            AI3.SizeMode = PictureBoxSizeMode.StretchImage;
            AI3.TabIndex = 5;
            AI3.TabStop = false;
            AI3.Tag = "carLower";
            // 
            // AI2
            // 
            AI2.BackColor = Color.Transparent;
            AI2.Image = Properties.Resources.ambulance;
            AI2.Location = new Point(731, 233);
            AI2.Name = "AI2";
            AI2.Size = new Size(43, 21);
            AI2.SizeMode = PictureBoxSizeMode.StretchImage;
            AI2.TabIndex = 4;
            AI2.TabStop = false;
            AI2.Tag = "carMiddle";
            // 
            // AI1
            // 
            AI1.BackColor = Color.Transparent;
            AI1.Image = Properties.Resources.carGreen;
            AI1.Location = new Point(731, 144);
            AI1.Name = "AI1";
            AI1.Size = new Size(53, 29);
            AI1.SizeMode = PictureBoxSizeMode.StretchImage;
            AI1.TabIndex = 3;
            AI1.TabStop = false;
            AI1.Tag = "carUpper";
            // 
            // obj2
            // 
            obj2.BackColor = Color.Transparent;
            obj2.Image = Properties.Resources._15;
            obj2.Location = new Point(15, 40);
            obj2.Name = "obj2";
            obj2.Size = new Size(32, 52);
            obj2.SizeMode = PictureBoxSizeMode.StretchImage;
            obj2.TabIndex = 2;
            obj2.TabStop = false;
            obj2.Click += obj2_Click;
            // 
            // obj1
            // 
            obj1.BackColor = Color.Transparent;
            obj1.Image = Properties.Resources._14;
            obj1.Location = new Point(118, 178);
            obj1.Name = "obj1";
            obj1.Size = new Size(30, 50);
            obj1.SizeMode = PictureBoxSizeMode.StretchImage;
            obj1.TabIndex = 1;
            obj1.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.BackgroundImageLayout = ImageLayout.Stretch;
            player.Image = Properties.Resources._5__1_;
            player.Location = new Point(606, 71);
            player.Name = "player";
            player.Size = new Size(32, 47);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtScore.ForeColor = Color.White;
            txtScore.Location = new Point(12, 474);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(65, 21);
            txtScore.TabIndex = 1;
            txtScore.Text = "Score: 0";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.White;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Location = new Point(721, 471);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(78, 30);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // txtObj
            // 
            txtObj.AutoSize = true;
            txtObj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtObj.ForeColor = Color.White;
            txtObj.Location = new Point(108, 474);
            txtObj.Name = "txtObj";
            txtObj.Size = new Size(111, 21);
            txtObj.TabIndex = 3;
            txtObj.Text = "People Left: 15";
            // 
            // Mission1_Flyers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 19, 19);
            ClientSize = new Size(811, 518);
            Controls.Add(txtObj);
            Controls.Add(btnRestart);
            Controls.Add(txtScore);
            Controls.Add(panel1);
            Name = "Mission1_Flyers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mision1_Flyers";
            Load += Mission1_Flyers_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AI3).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)obj2).EndInit();
            ((System.ComponentModel.ISupportInitialize)obj1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txtScore;
        private Button btnRestart;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox AI3;
        private PictureBox AI2;
        private PictureBox AI1;
        private PictureBox obj2;
        private PictureBox obj1;
        private PictureBox player;
        private Label txtObj;
    }
}