namespace TsuperMan
{
    partial class LoadingForms
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
            Timer = new ProgressBar();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Location = new Point(12, 744);
            Timer.Name = "Timer";
            Timer.Size = new Size(1507, 29);
            Timer.TabIndex = 0;
            Timer.Click += progressBar1_Click;
            // 
            // LoadingForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2024_05_17_21_13_42;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1531, 785);
            Controls.Add(Timer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForms";
            Text = "LoadingForms";
            Load += LoadingForms_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar Timer;
        private Label label1;
    }
}