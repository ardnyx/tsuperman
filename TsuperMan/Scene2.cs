using InsideHouse;
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
                    ShowContinueIndication();
                }
            };
            animationTimer.Start();
        }

        private void ShowContinueIndication()
        {
            panel1.Click += Scene2Pnl_Click;
        }

        private void Scene2Pnl_Click(object? sender, EventArgs e)
        {
            panel1.Click -= Scene2Pnl_Click; // Remove the event handler to prevent multiple transitions
            TransitionToInsideHouseForm();
        }

        private void TransitionToInsideHouseForm()
        {
            // Hide the current form before showing the new form
            this.Hide();

            // Show the InsideHouse.Form1
            InsideHouse.Form1 form1 = new InsideHouse.Form1();
            form1.Show();

            // Close the current form after a small delay to ensure the new form is shown
            var closeTimer = new System.Windows.Forms.Timer();
            closeTimer.Interval = 100; // 0.1 seconds delay
            closeTimer.Tick += (s, args) =>
            {
                closeTimer.Stop();
                closeTimer.Dispose();
                this.Close();
            };
            closeTimer.Start();
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
