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
    public partial class LR_Dialogue_Section_1 : Form
    {
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private string playerMsgText = "Morning, Dad. Heading out early again?";
        private System.Windows.Forms.Timer animationTimer;

        public LR_Dialogue_Section_1()
        {
            InitializeComponent();
            this.Load += new EventHandler(LR_Dialogue_Section_1_Load);
            this.MouseClick += new MouseEventHandler(MouseClick_Part1);
        }

        private void LR_Dialogue_Section_1_Load(object sender, EventArgs e)
        {
            playerName.Text = "Protagonist";
            playerMsg.Text = string.Empty;

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();
        }

        private void AnimateText(object sender, EventArgs e)
        {
            if (dialogueCounter == 1)
            {
                playerMsgText = "Yes, anak. Got to make the most of it. The government's pushing hard for this new modernization program.";
            }
            else if (dialogueCounter == 2)
            {
                playerName.Text = "Protagonist";
                playerMsgText = "Modernization Program?";
            }
            else if (dialogueCounter == 3)
            {
                playerName.Text = "Father";
                playerMsgText = "They're planning to phase out all traditional jeepneys in favor of modern ones. It'll make it impossible for drivers like me to keep going..";
            }
            else if (dialogueCounter == 4)
            {
                LivingRoom_Part2 livingRoom_Part2 = new LivingRoom_Part2();
                livingRoom_Part2.Show();
                this.Hide();
                dialogueCounter = -1;
            }

            if (msgIndex < playerMsgText.Length)
            {
                playerMsg.Text += playerMsgText[msgIndex];
                msgIndex++;
            }
            else
            {
                animationTimer.Stop();
            }
        }

        private void MouseClick_Part1(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerName.Text = "Father";
            playerMsg.Text = string.Empty;

            // Start animation for the father's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();

            // Ensure text wraps when dialogue exceeds form size
            playerMsg.AutoSize = false;
            playerMsg.Width = this.ClientSize.Width - playerMsg.Location.X * 2; // Adjust X position for padding
            playerMsg.Height = this.ClientSize.Height - playerMsg.Location.Y * 2; // Adjust Y position for padding

            // Add MouseClick_Part2 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part1; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part2; // Add the MouseClick_Part2 event handler
                }
            });
        }

        private void MouseClick_Part2(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerMsg.Text = string.Empty;

            // Start animation for the father's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();

            // Ensure text wraps when dialogue exceeds form size
            playerMsg.AutoSize = false;
            playerMsg.Width = this.ClientSize.Width - playerMsg.Location.X * 2; // Adjust X position for padding
            playerMsg.Height = this.ClientSize.Height - playerMsg.Location.Y * 2; // Adjust Y position for padding

            // Add MouseClick_Part3 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part2; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part3; // Add the MouseClick_Part2 event handler
                }
            });
        }

        private void MouseClick_Part3(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerMsg.Text = string.Empty;

            // Start animation for the third dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();

            // Ensure text wraps when dialogue exceeds form size
            playerMsg.AutoSize = false;
            playerMsg.Width = this.ClientSize.Width - playerMsg.Location.X * 2; // Adjust X position for padding
            playerMsg.Height = this.ClientSize.Height - playerMsg.Location.Y * 2; // Adjust Y position for padding

            // Add MouseClick_Part3 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part2; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part3; // Add the MouseClick_Part2 event handler
                }
            });
        }

        private void MouseClick_Part4(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerMsg.Text = string.Empty;
        }

    }
}
