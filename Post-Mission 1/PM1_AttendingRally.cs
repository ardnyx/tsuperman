using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Post_Mission_1
{
    public partial class PM1_AttendingRally : Form
    {
        bool nextFormOpen = false;
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private string playerMsgText = "Today's a big day! I'll be attending a rally to further fight for my father’s livelihood.";
        private System.Windows.Forms.Timer animationTimer;
        public PM1_AttendingRally()
        {
            InitializeComponent();
            this.Load += new EventHandler(PM1_AttendingRally_Load);
            this.MouseClick += new MouseEventHandler(MouseClick_Part1);
        }

        private void PM1_AttendingRally_Load(object sender, EventArgs e)
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
            // 2nd dialogue
            if (dialogueCounter == 1)
            {
                playerMsgText = "Hmm? What's that noise outside?";
            }
            // 3rd dialogue (next form)
            else if (dialogueCounter == 2 && !nextFormOpen)
            {
                nextFormOpen = true;
                PM1_LivingRoom_Part2 pM1_LivingRoom_Part2 = new PM1_LivingRoom_Part2();
                pM1_LivingRoom_Part2.Show();
                this.Hide();
                this.Close();
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
        }
    }
}
