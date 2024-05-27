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
    public partial class PM1_EnteringTheHouse : Form
    {
        bool goUp, goDown, goLeft, goRight; // movements
        int speed = 5; // Speed of the player
        List<PictureBox> walls = new List<PictureBox>(); // For Wall Detector
        System.Windows.Forms.Timer moveTimer;
        bool nextFormOpen = false;
        public PM1_EnteringTheHouse()
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

        private void PM1_EnteringTheHouse_Load(object sender, EventArgs e)
        {

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
            }

            CheckInteraction();
        }

        private void CheckInteraction()
        {
            // Define the specific point for interaction
            Point interactionPoint = new Point(771, 256);

            // Check if the protagonist is at the interaction point
            if (protagonist.Bounds.Contains(interactionPoint) && !nextFormOpen)
            {
                nextFormOpen = true;
                PM1_AttendingRally pM1_AttendingRally = new PM1_AttendingRally();
                pM1_AttendingRally.Show();
                this.Hide();
                this.Close();
            }
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
