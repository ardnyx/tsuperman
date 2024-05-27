using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission1_Tsuperman
{
    public partial class Mission1_Win : Form
    {
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private System.Windows.Forms.Timer animationTimer;
        private bool nextFormOpen = false;
        public Mission1_Win()
        {
            InitializeComponent();
            this.MouseClick += new MouseEventHandler(OneClick);
        }

        private void Mission1_Win_Load(object sender, EventArgs e)
        {

        }

        private void AnimateText(object sender, EventArgs e)
        {
            if (dialogueCounter == 1 && !nextFormOpen)
            {
                nextFormOpen = true;
                Post_Mission_1.Form1 form1 = new Post_Mission_1.Form1();
                form1.Show();
                this.Hide();
                this.Close();
            }
        }
        private void OneClick(object sender, MouseEventArgs e)
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
