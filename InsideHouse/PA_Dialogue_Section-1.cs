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
    public partial class PA_Dialogue_Section_1 : Form
    {
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private string playerMsgText = "Good day Ms. Mayor, Can I speak with you for a moment?";
        private System.Windows.Forms.Timer animationTimer;
        public PA_Dialogue_Section_1()
        {
            InitializeComponent();
            this.Load += new EventHandler(PA_Dialogue_Section_1_Load);
            this.MouseClick += new MouseEventHandler(MouseClick_Part1);
        }



        private void protagonist_Click(object sender, EventArgs e)
        {
            // ACCIDENT
        }

        private void PA_Dialogue_Section_1_Load(object sender, EventArgs e)
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
            //start of 2nd dialogue
            if (dialogueCounter == 1)
            {
                playerMsgText = "Of course. What's on your mind?";
            }
            // 3rd dialogue
            else if (dialogueCounter == 2)
            {
                playerName.Text = "Protagonist";
                playerMsgText = "I need advice on how to fight this jeepney phaseout. It's affecting my family and so many others.";
            }
            // 4th dialogue
            else if (dialogueCounter == 3)
            {
                playerName.Text = "Local Politician";
                playerMsgText = "You need to raise awareness first. Start by distributing flyers, get the community involved. Show them why this matters.";
            }
            // 5th dialogue
            else if (dialogueCounter == 4)
            {
                playerName.Text = "Protagonist";
                playerMsgText = "Hmmm.. Aha!";
            }
            // 6th dialogue
            else if (dialogueCounter == 5)
            {
                playerName.Text = "Protagonist";
                playerMsgText = "How about I distribute flyers to people around here, to raise their awareness!";
            }
            //7th dialogue
            else if (dialogueCounter == 6)
            {
                playerName.Text = "Local Politician";
                playerMsgText = "That's a good idea!";
            }
            // next form
            else if (dialogueCounter == 7)
            {
                // next form
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

        // start of 2nd dialogue
        private void MouseClick_Part1(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerName.Text = "Local Politician";
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

        // 3rd dialogue
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

            // Add MouseClick_Part2 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part2; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part3; // Add the MouseClick_Part2 event handler
                }
            });
        }

        // 4th dialogue
        private void MouseClick_Part3(object sender, MouseEventArgs e)
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

            // Add MouseClick_Part2 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part3; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part4; // Add the MouseClick_Part2 event handler
                }
            });
        }

        // 5th dialogue
        private void MouseClick_Part4(object sender, MouseEventArgs e)
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

            // Add MouseClick_Part2 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part4; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part5; // Add the MouseClick_Part2 event handler
                }
            });
        }

        // 6th dialogue
        private void MouseClick_Part5(object sender, MouseEventArgs e)
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

            // Add MouseClick_Part2 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part5; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part6; // Add the MouseClick_Part2 event handler
                }
            });
        }

        // 7th dialogue
        private void MouseClick_Part6(object sender, MouseEventArgs e)
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

            // Add MouseClick_Part2 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part6; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part7; // Add the MouseClick_Part2 event handler
                }
            });
        }

        //ending
        private void MouseClick_Part7(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerMsg.Text = string.Empty;

            // Start animation for the father's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();
        }
    }
}
