using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace InsideHouse
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, goLeft, goRight; // movements
        int speed = 5; // Speed of the player
        List<PictureBox> walls = new List<PictureBox>(); // For Wall Detector
        System.Windows.Forms.Timer moveTimer; // dont know what is this for basta sabi ni chatgpt

        public Form1()
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

            // lahat ng mga picturebox na gusto ko madetect as a wall, nandito, kahit yung mga parents, table, nandito, para isahang tawagan lang
            // For example:
            walls.Add(wall_1);
            walls.Add(wall_2);
            walls.Add(wall_3);
            walls.Add(wall_4);
        }

        // kailangan mo to isetup sa Event Handlers sa form, click mo ung form, tas sa gilid ng properties may parang lightning bolt don, tas hanapin mo yung keyDown, pinangalanan kong keyIsDown
        private void keyIsDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
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
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
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
            // if go(Position) is true, and as long as walang collision na nangyayari
            if (goUp && protagonist.Top > 0 && !IsCollision(new Point(protagonist.Left, protagonist.Top - speed)))
            {
                protagonist.Top -= speed;
            }
            if (goDown && protagonist.Bottom < this.ClientSize.Height && !IsCollision(new Point(protagonist.Left, protagonist.Top + speed)))
            {
                protagonist.Top += speed;
            }
            if (goLeft && protagonist.Left > 0 && !IsCollision(new Point(protagonist.Left - speed, protagonist.Top)))
            {
                protagonist.Left -= speed;
            }
            if (goRight && protagonist.Right < this.ClientSize.Width && !IsCollision(new Point(protagonist.Left + speed, protagonist.Top)))
            {
                protagonist.Left += speed;

                // Check if the protagonist has reached the rightmost edge
                if (protagonist.Right >= this.ClientSize.Width)
                {
                    ShowLivingRoom();
                }
            }
        }

        // chinatgpt ko lang tong collision detector kase ang hirap, basta its a bool for knowing if yung dinefine kong shape for the player hits a collision (wall).
        private bool IsCollision(Point newLocation)
        {
            // Define the lower portion of the protagonist for collision detection
            int lowerBodyHeight = protagonist.Height / 3;
            Rectangle lowerBodyBounds = new Rectangle(
                newLocation.X,
                newLocation.Y + (protagonist.Height - lowerBodyHeight),
                protagonist.Width,
                lowerBodyHeight
            );

            foreach (var wall in walls)
            {
                if (lowerBodyBounds.IntersectsWith(wall.Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        private void ShowLivingRoom()
        {
            // Stop the timer to prevent further movement
            moveTimer.Stop();

            // Create and show the LivingRoom form
            LivingRoom livingRoom = new LivingRoom();
            livingRoom.Show();

            // Optionally hide or close the current form
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // wala yan btw, first trial ko yan di pede tanggalin mageerror ung form eh
            protagonist.Left = 215;
            protagonist.Top = 190;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // wala din to
        }
    }
}
