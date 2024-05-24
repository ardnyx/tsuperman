namespace TsuperMan
{
    partial class SelectChar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectChar));
            Char1Btn = new Button();
            Char2Btn = new Button();
            CharPnl = new Panel();
            CharPnl.SuspendLayout();
            SuspendLayout();
            // 
            // Char1Btn
            // 
            Char1Btn.FlatAppearance.BorderSize = 0;
            Char1Btn.FlatStyle = FlatStyle.Flat;
            Char1Btn.Image = Properties.Resources.Untitled_design__12__removebg_preview1;
            Char1Btn.Location = new Point(943, 546);
            Char1Btn.Name = "Char1Btn";
            Char1Btn.Size = new Size(268, 94);
            Char1Btn.TabIndex = 1;
            Char1Btn.UseVisualStyleBackColor = true;
            Char1Btn.Click += Char1Btn_Click;
            // 
            // Char2Btn
            // 
            Char2Btn.FlatAppearance.BorderSize = 0;
            Char2Btn.FlatStyle = FlatStyle.Flat;
            Char2Btn.Image = Properties.Resources.Untitled_design__12__removebg_preview;
            Char2Btn.Location = new Point(311, 546);
            Char2Btn.Name = "Char2Btn";
            Char2Btn.Size = new Size(268, 94);
            Char2Btn.TabIndex = 2;
            Char2Btn.UseVisualStyleBackColor = true;
            Char2Btn.Click += Char2Btn_Click;
            // 
            // CharPnl
            // 
            CharPnl.BackColor = Color.Transparent;
            CharPnl.BackgroundImage = (Image)resources.GetObject("CharPnl.BackgroundImage");
            CharPnl.BackgroundImageLayout = ImageLayout.Stretch;
            CharPnl.Controls.Add(Char1Btn);
            CharPnl.Controls.Add(Char2Btn);
            CharPnl.Dock = DockStyle.Fill;
            CharPnl.Location = new Point(0, 0);
            CharPnl.Name = "CharPnl";
            CharPnl.Size = new Size(1531, 785);
            CharPnl.TabIndex = 3;
            CharPnl.Paint += CharPnl_Paint;
            // 
            // SelectChar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 785);
            Controls.Add(CharPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectChar";
            Text = "SelectChar";
            Load += SelectChar_Load;
            CharPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button Char1Btn;
        private Button Char2Btn;
        private Panel CharPnl;
    }
}