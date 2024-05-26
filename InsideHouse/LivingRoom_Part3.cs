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
    public partial class LivingRoom_Part3 : Form
    {
        bool goUp, goDown, goLeft, goRight;
        int speed = 5;
        bool dialogueFormOpen = false;
        List<PictureBox> walls = new List<PictureBox>();
        System.Windows.Forms.Timer moveTimer;
        public LivingRoom_Part3()
        {
            InitializeComponent();
        }

        private void LivingRoom_Part3_Load(object sender, EventArgs e)
        {
            // Set up the Timer
            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = 20; // Adjust as needed
            moveTimer.Tick += new EventHandler(MoveTimer_Tick);
            moveTimer.Start();

            // Register key events
            this.KeyDown += new KeyEventHandler(keyIsDown);
            this.KeyUp += new KeyEventHandler(keyIsUp);

            // Add your wall PictureBoxes to the list
            // For example:
            walls.Add(wall_1);
            walls.Add(wall_2);
            walls.Add(wall_3);
            walls.Add(wall_4);
            walls.Add(wall_5);
            walls.Add(wall_6);
            walls.Add(wall_7);
            walls.Add(wall_8);

            walls.Add(father);
            walls.Add(mother);
            walls.Add(sibling);
            walls.Add(table);
        }

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

        private void MoveProtagonist()
        {
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

                // Check if the protagonist has reached the leftmost edge
                if (protagonist.Left >= this.ClientSize.Width)
                {
                    ShowLeavingTheHouse();
                }
            }
            if (goRight && protagonist.Right < this.ClientSize.Width && !IsCollision(new Point(protagonist.Left + speed, protagonist.Top)))
            {
                protagonist.Left += speed;
            }
        }

        private void ShowLeavingTheHouse()
        {
            // Stop the timer to prevent further movement
            moveTimer.Stop();

            // Create and show the LeavingTheHouse form
            

            // Optionally hide or close the current form
            this.Hide();
        }
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
    }
}
