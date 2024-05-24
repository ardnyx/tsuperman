using System;
using System.Windows.Forms;

namespace TsuperMan
{
    public partial class Scene2 : Form
    {
        private Panel parentPanel;

        public Scene2(Panel parent)
        {
            InitializeComponent();
            parentPanel = parent;
        }

        public void StartTextAnimation()
        {
            string textToAnimate = "My father has been a jeepney driver for as long as I can remember, \r\n         and our family has always been proud of this tradition.";
            label1.Text = "";
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 70; // Adjust the interval as needed
            int currentIndex = 0;

            animationTimer.Tick += (s, args) =>
            {
                if (currentIndex < textToAnimate.Length)
                {
                    label1.Text += textToAnimate[currentIndex];
                    currentIndex++;
                }
                else
                {
                    animationTimer.Stop(); // Stop the timer when the text is fully displayed
                }
            };
            animationTimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This can be left empty or used if you want to handle label1 specific clicks
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle panel paint event if needed
        }
    }
}
