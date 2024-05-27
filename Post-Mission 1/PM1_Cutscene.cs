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
    public partial class PM1_Cutscene : Form
    {
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private string playerMsgText = "Wow! So much people showed up for today's rally!";
        private System.Windows.Forms.Timer animationTimer;
        private int caseSwitch = 0;
        private bool nextFormOpen = false;
        public PM1_Cutscene()
        {
            InitializeComponent();
            this.Load += new EventHandler(PM1_Cutscene_Load);
            this.MouseClick += new MouseEventHandler(MouseClick_Part1);
        }

        private void PM1_Cutscene_Load(object sender, EventArgs e)
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
                timer1.Enabled = false;
                this.BackgroundImage = Properties.Resources.savethejeepneys;
                playerMsgText = "I guess while we're here, we could collect their signatures for the petition!";
            }
            else if (dialogueCounter == 2 && !nextFormOpen)
            {
                nextFormOpen = true;
                Post_Mission_2.Form1 form1 = new Post_Mission_2.Form1();
                form1.Show();
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
        // 2nd part of dialogue
        private void MouseClick_Part1(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerMsg.Text = string.Empty;

            // Start animation for the protagonist's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();

            // Ensure text wraps when dialogue exceeds form size
            playerMsg.AutoSize = false;
            playerMsg.Width = this.ClientSize.Width - playerMsg.Location.X * 2; // Adjust X position for padding
            playerMsg.Height = this.ClientSize.Height - playerMsg.Location.Y * 2; // Adjust Y position for padding

            // Add MouseClick_Part2 event handler after the protagonist's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part1; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part2;
                }
            });
        }
        private void MouseClick_Part2(object sender, MouseEventArgs e)
        {
            dialogueCounter++;
            playerMsg.Text = string.Empty;

            // Start animation for the protagonist's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            caseSwitch++;
            switch (caseSwitch)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.rally_bg1;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.rally_bg2;
                    break;
            }

            if (caseSwitch == 2) caseSwitch = 0;
        }
    }
}
