namespace TsuperMan
{
    partial class Scene1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scene1));
            Scene1Pnl = new Panel();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Scene1Pnl.SuspendLayout();
            SuspendLayout();
            // 
            // Scene1Pnl
            // 
            Scene1Pnl.BackgroundImage = (Image)resources.GetObject("Scene1Pnl.BackgroundImage");
            Scene1Pnl.BackgroundImageLayout = ImageLayout.Stretch;
            Scene1Pnl.Controls.Add(label2);
            Scene1Pnl.Controls.Add(label1);
            Scene1Pnl.Location = new Point(0, 0);
            Scene1Pnl.Name = "Scene1Pnl";
            Scene1Pnl.Size = new Size(1531, 770);
            Scene1Pnl.TabIndex = 0;
            Scene1Pnl.Paint += Scene1Pnl_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1209, 741);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 2;
            label2.Text = "Click anywhere to continue";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(326, 695);
            label1.Name = "label1";
            label1.Size = new Size(986, 35);
            label1.TabIndex = 1;
            label1.Text = "Manila, my home. A city alive with the sound of jeepneys and the hustle of everyday life.";
            label1.Click += label1_Click_1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Scene1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 785);
            Controls.Add(Scene1Pnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Scene1";
            Text = "Scene1";
            Load += Scene1_Load;
            Scene1Pnl.ResumeLayout(false);
            Scene1Pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Scene1Pnl;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
    }
}
