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
    public partial class PoliticianArea : Form
    {
        bool goLeft, goRight;
        int speed = 5; // Speed of the player
        System.Windows.Forms.Timer moveTimer; // dont know what is this for basta sabi ni chatgpt

        public PoliticianArea()
        {
            InitializeComponent();
            // Set up the Timer
            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = 20; // Adjust as needed
            moveTimer.Tick += new EventHandler(MoveTimer_Tick);
            moveTimer.Start();

            // Register key events
            this.KeyDown += new KeyEventHandler(keyIsDown);
            this.KeyUp += new KeyEventHandler(keyIsUp);
        }

        // kailangan mo to isetup sa Event Handlers sa form, click mo ung form, tas sa gilid ng properties may parang lightning bolt don, tas hanapin mo yung keyDown, pinangalanan kong keyIsDown
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }

        // did the same thing here
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MoveProtagonist();
        }

        // eto, para to sa movement ng player
        private void MoveProtagonist()
        {
            if (goLeft && protagonist.Left > 0)
            {
                protagonist.Left -= speed;
            }
            if (goRight && protagonist.Right < this.ClientSize.Width)
            {
                protagonist.Left += speed;
            }

            if (protagonist.Left <= 0)
            {
                TalkToPoliticianArea();
            }
        }
    }
}
