using System;
using System.Text;
using System.Windows.Forms;

namespace TsuperMan
{
    public partial class Scene1 : Form
    {
        private Panel parentPanel;

        public Scene1(Panel parent)
        {
            InitializeComponent();
            parentPanel = parent;
            this.Load += Scene1_Load;
            label2.Visible = false; // Initially hide label2
        }

        private void Scene1_Load(object? sender, EventArgs e)
        {
            StartTextAnimation();
        }

        public void StartTextAnimation()
        {
            string textToAnimate = "Manila, my home. A city alive with the sound of jeepneys and the hustle of everyday life.    ";

            label1.Text = "";
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 50;
            int currentIndex = 0;
            StringBuilder animatedText = new StringBuilder();

            animationTimer.Tick += (s, args) =>
            {
                if (currentIndex < textToAnimate.Length)
                {
                    animatedText.Append(textToAnimate[currentIndex]);
                    label1.Text = animatedText.ToString();
                    currentIndex++;
                }
                else
                {
                    animationTimer.Stop();
                    ShowContinueIndication();
                }
            };
            animationTimer.Start();
        }

        private void ShowContinueIndication()
        {
            label2.Text = "Click anywhere to continue...";
            label2.Visible = true; 
            Scene1Pnl.Click += Scene1Pnl_Click; 
        }
        
        private void Scene1Pnl_Click(object? sender, EventArgs e)
        {
            Scene1Pnl.Click -= Scene1Pnl_Click; // Remove the event handler to prevent multiple transitions
            TransitionToScene2();
        }

        private void TransitionToScene2()
        {
            Scene2 scene2 = new Scene2(parentPanel);
            scene2.TopLevel = false;
            scene2.FormBorderStyle = FormBorderStyle.None;
            scene2.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(scene2);
            scene2.BringToFront();
            Scene1Pnl.Visible = false;
            this.Hide();
            scene2.Show();
            scene2.StartTextAnimation();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label1 specific clicks if needed
        }

        private void Scene1Pnl_Paint(object sender, PaintEventArgs e)
        {
            // Handle panel paint event if needed
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Handle timer tick event if needed
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // Handle label1 specific clicks if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label2 specific clicks if needed
        }
    }
}
