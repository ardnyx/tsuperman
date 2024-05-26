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
    public partial class LR_Dialogue_Section_3 : Form
    {
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private string playerMsgText = "I can't let this happen, my education depends on my father's livelihood!";
        private System.Windows.Forms.Timer animationTimer;
        public LR_Dialogue_Section_3()
        {
            InitializeComponent();
            this.Load += new EventHandler(LR_Dialogue_Section_3_Load);
            this.MouseClick += new MouseEventHandler(MouseClick_Part1);
        }

        private void LR_Dialogue_Section_3_Load(object sender, EventArgs e)
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
                OutsideHouse outsideHouse = new OutsideHouse();
                outsideHouse.Show();
                this.Hide();
                this.Close();
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

            // Start animation for the father's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();
        }
    }
}
