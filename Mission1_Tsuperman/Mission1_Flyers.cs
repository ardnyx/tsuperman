using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission1_Tsuperman
{



    public partial class Mission1_Flyers : Form
    {
        Mission1_Win Mission1_Win;

        int playerSpeed = 10;
        int trafficSpeed;
        int score;
        int objRemaining = 15;

        Random rand = new Random();

        bool goleft, goright, goup, godown;

        private List<Point> possiblePositions = new List<Point>
        {
            new Point(655, 295),
            new Point(605, 70),
            new Point(118, 178),
            new Point(230, 275),
            new Point(720, 280),
            new Point(15, 40)
        };
        private List<Point> occupiedPositions = new List<Point>();

        private void TeleportObject(PictureBox obj)
        {
            // Remove the object's current position from the occupied positions list
            occupiedPositions.Remove(obj.Location);

            // Randomly choose one of the predefined positions that is not currently occupied
            Point newPosition;
            do
            {
                int randomIndex = rand.Next(possiblePositions.Count);
                newPosition = possiblePositions[randomIndex];
            }
            while (occupiedPositions.Contains(newPosition));

            // Set the new position and update the occupied positions list
            obj.Location = newPosition;
            occupiedPositions.Add(newPosition);
        }

        public Mission1_Flyers()
        {
            InitializeComponent();
            ResetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (goleft == true && player.Left > 3)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 748)
            {
                player.Left += playerSpeed;
            }
            if (goup && player.Top > 3)
            {
                player.Top -= playerSpeed;
            }
            if (godown && player.Bottom < 430) // Adjusted to accommodate the player's height
            {
                player.Top += playerSpeed;
            }

            AI1.Left -= trafficSpeed;
            AI2.Left -= trafficSpeed;
            AI3.Left -= trafficSpeed;

            if (AI1.Left < 0)
            {
                changeAIcars(AI1);
            }
            if (AI2.Left < 0)
            {
                changeAIcars(AI2);
            }
            if (AI3.Left < 0)
            {
                changeAIcars(AI3);
            }

            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds) || player.Bounds.IntersectsWith(AI3.Bounds))
            {
                gameOver();
            }

            if (player.Bounds.IntersectsWith(obj1.Bounds))
            {
                changeObj(obj1);
                score += 100; // Increment score by 100
                txtScore.Text = "Score: " + score;
                TeleportObject(obj1); // Teleport obj1 to a new location
                --objRemaining;
                txtObj.Text = "People Left: " + objRemaining;
                winGame();
            }

            if (player.Bounds.IntersectsWith(obj2.Bounds))
            {
                changeObj(obj2);
                score += 100; // Increment score by 100
                txtScore.Text = "Score: " + score;
                TeleportObject(obj2); // Teleport obj2 to a new location
                --objRemaining;
                txtObj.Text = "People Left: " + objRemaining;
                winGame();
            }
        }

        private void changeObj(PictureBox tempobj)
        {
            int objImage = rand.Next(1, 5); // Random value between 1 and 4

            switch (objImage)
            {
                case 1:
                    tempobj.Image = Properties.Resources._14;
                    break;
                case 2:
                    tempobj.Image = Properties.Resources._17;
                    break;
                case 3:
                    tempobj.Image = Properties.Resources._18;
                    break;
                case 4:
                    tempobj.Image = Properties.Resources._15;
                    break;
            }
        }

        private void changeAIcars(PictureBox tempcar)
        {
            int carImage = rand.Next(1, 10); // Random value between 1 and 9

            switch (carImage)
            {
                case 1:
                    tempcar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempcar.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempcar.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempcar.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempcar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempcar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempcar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempcar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempcar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            // Determine the lane based on the car's tag
            if ((string)tempcar.Tag == "carUpper")
            {
                tempcar.Left = 730;  // Set a static position for upper lane
            }
            else if ((string)tempcar.Tag == "carMiddle")
            {
                tempcar.Left = 770;  // Set a static position for middle lane
            }
            else if ((string)tempcar.Tag == "carLower")
            {
                tempcar.Left = 1000;  // Set a static position for lower lane
            }
        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            btnRestart.Enabled = true;
        }

        private void ResetGame()
        {
            btnRestart.Enabled = false;
            goup = false;
            godown = false;
            goleft = false;
            goright = false;
            score = 0;
            objRemaining = 15;
            trafficSpeed = 15;
            occupiedPositions.Clear();

            gameTimer.Start();

            AI1.Left = 748;
            AI2.Left = 748;
            AI3.Left = 748;

            // Reset object positions and add to occupied positions list
            TeleportObject(obj1);
            TeleportObject(obj2);
        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.gameover);
            playCrash.Play();
        }

        private void winGame()
        {
            if (objRemaining == 0)
            {
                btnRestart.Enabled = true;
                trafficSpeed = 0;
                goup = false;
                godown = false;
                goleft = false;
                goright = false;

                score = 0;

                Mission1_Win = new Mission1_Win();
                Mission1_Win.Visible = true;
                this.Visible = false;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void obj2_Click(object sender, EventArgs e)
        {

        }

        private void Mission1_Flyers_Load(object sender, EventArgs e)
        {
            Mission1_Win = new Mission1_Win();
            Mission1_Win.Visible = false;
            this.Visible = true;
        }
    }
}
