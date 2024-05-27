namespace Post_Mission_1
{
    partial class PM1_NextDayTransition
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
            playerName = new Label();
            SuspendLayout();
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.BackColor = Color.Black;
            playerName.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.White;
            playerName.Location = new Point(339, 236);
            playerName.Name = "playerName";
            playerName.Size = new Size(178, 46);
            playerName.TabIndex = 1;
            playerName.Text = "Next Day...";
            // 
            // PM1_NextDayTransition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(856, 518);
            Controls.Add(playerName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PM1_NextDayTransition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PM1_NextDayTransition";
            Load += PM1_NextDayTransition_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label playerName;
    }
}