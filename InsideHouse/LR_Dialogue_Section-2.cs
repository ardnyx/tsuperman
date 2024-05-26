using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsideHouse
{
    public partial class LR_Dialogue_Section_2 : Form
    {
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private string playerMsgText = "This can't be happening. Our jeepney is more than just a vehicle.";
        private System.Windows.Forms.Timer animationTimer;

        public LR_Dialogue_Section_2()
        {
            InitializeComponent();
            this.Load += new EventHandler(LR_Dialogue_Section_2_Load);
            this.MouseClick += new MouseEventHandler(OneClick);
        }

        private void LR_Dialogue_Section_2_Load(object sender, EventArgs e)
        {
            playerName.Text = string.Empty;

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();
        }

        private void AnimateText(object sender, EventArgs e)
        {
            if (dialogueCounter == 1)
            {
                playerMsgText = "It's a symbol of our heritage!";
            }
            else if (dialogueCounter == 2)
            {
                LivingRoom_Part3 livingRoom_Part3 = new LivingRoom_Part3();
                livingRoom_Part3.Show();
                this.Hide();
                dialogueCounter = -1;
            }

            if (msgIndex < playerMsgText.Length)
            {
                playerName.Text += playerMsgText[msgIndex];
                msgIndex++;
            }
            else
            {
                animationTimer.Stop();
            }
        }

        private void OneClick(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerName.Text = string.Empty;

            // Start animation for the father's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();

            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= OneClick; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += SecondClick; // Add the MouseClick_Part2 event handler
                }
            });
        }

        private void SecondClick(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerName.Text = string.Empty;

            // Start animation for the father's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();

            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= SecondClick; // Remove the MouseClick_Part1 event handler
                }
            });
        }

        private void LR_Dialogue_Section_2_MouseClick(object sender, MouseEventArgs e)
        {
            //Nothing should be here, its an accident
        }
    }
}
