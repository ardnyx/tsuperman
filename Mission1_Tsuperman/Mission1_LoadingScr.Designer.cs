namespace Mission1_Tsuperman
{
    partial class Mission1_LoadingScr
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            startLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(20, 19, 19);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(354, 182);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 0;
            label1.Text = "Mission 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(20, 19, 19);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(354, 203);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Loading...";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(20, 19, 19);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(230, 434);
            label3.Name = "label3";
            label3.Size = new Size(325, 21);
            label3.TabIndex = 2;
            label3.Text = "Distribute the Flyers, Watch out for the Timer!\r\n";
            label3.Click += label3_Click;
            // 
            // startLabel
            // 
            startLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            startLabel.AutoSize = true;
            startLabel.BackColor = Color.FromArgb(20, 19, 19);
            startLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startLabel.ForeColor = Color.White;
            startLabel.Location = new Point(724, 488);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(75, 21);
            startLabel.TabIndex = 4;
            startLabel.Text = "Start>>>";
            startLabel.Click += startLabel_Click;
            // 
            // Mission1_LoadingScr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 19, 19);
            ClientSize = new Size(811, 518);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startLabel);
            Name = "Mission1_LoadingScr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mission1_LoadingScr";
            Load += Mission1_LoadingScr_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label startLabel;
    }
}