using System;
using System.Windows.Forms;

namespace Mission1_Tsuperman
{
    public partial class Mission1_Game1 : UserControl
    {

        int playerSpeed = 12;
        int trafficSpeed;
        int score;
        int carImage;

        Random rand = new Random();

        bool goleft, goright, goup, godown;

        public Mission1_Game1()
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
            if (goright == true && player.Left < 760)
            {
                player.Left += playerSpeed;
            }
            if (goup && player.Top > 3)
            {
                player.Top -= playerSpeed;
            }
            if (godown && player.Bottom < 467) // Adjusted to accommodate the player's height
            {
                player.Top += playerSpeed;
            }

        }

        private void changeAIcars(PictureBox tempcar)
        {

        }

        private void gameOver()
        {

        }

        private void ResetGame()
        {
            btnRestart.Enabled = false;
            goup = false;
            godown = false;
            goleft = false;
            goright = false;
            score = 0;
            trafficSpeed = 15;

            gameTimer.Start();
        }

        private void playSound()
        {

        }

        private void Mission1_Game1_Load(object sender, EventArgs e)
        {

        }
    }
}