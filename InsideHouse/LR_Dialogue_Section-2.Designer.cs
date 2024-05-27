namespace InsideHouse
{
    partial class LR_Dialogue_Section_2
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
            playerName.BackColor = Color.Transparent;
            playerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.White;
            playerName.Location = new Point(69, 441);
            playerName.Name = "playerName";
            playerName.Size = new Size(46, 28);
            playerName.TabIndex = 1;
            playerName.Tag = "";
            playerName.Text = "Text";
            playerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LR_Dialogue_Section_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(856, 518);
            Controls.Add(playerName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LR_Dialogue_Section_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LR_Dialogue_Section_2";
            Load += LR_Dialogue_Section_2_Load;
            MouseClick += LR_Dialogue_Section_2_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label playerName;
    }
}