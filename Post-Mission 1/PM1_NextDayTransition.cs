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
    public partial class PM1_NextDayTransition : Form
    {
        bool nextFormOpen = false;
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private string playerMsgText = "Next Day...";
        private System.Windows.Forms.Timer animationTimer;
        public PM1_NextDayTransition()
        {
            InitializeComponent();
            this.Load += new EventHandler(PM1_NextDayTransition_Load);
            this.MouseClick += new MouseEventHandler(OneClick);
        }

        private void PM1_NextDayTransition_Load(object sender, EventArgs e)
        {
            playerName.Text = string.Empty;

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();
        }

        private void AnimateText(object sender, EventArgs e)
        {
            if (dialogueCounter == 1 && !nextFormOpen)
            {
                nextFormOpen = true;
                PM1_EnteringTheHouse pM1_EnteringTheHouse = new PM1_EnteringTheHouse();
                pM1_EnteringTheHouse.Show();
                this.Hide();
                this.Close();
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
        }
    }
}
