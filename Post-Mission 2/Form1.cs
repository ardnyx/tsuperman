namespace Post_Mission_2
{
    public partial class Form1 : Form
    {
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private string playerMsgText = "In recent news, the government is doubling down on the jeepney modernization program despite public protests.";
        private System.Windows.Forms.Timer animationTimer;
        private int caseSwitch = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.MouseClick += new MouseEventHandler(MouseClick_Part1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            playerName.Text = "News Anchor";
            playerMsg.Text = string.Empty;

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();

            // Ensure text wraps when dialogue exceeds form size
            playerMsg.AutoSize = false;
            playerMsg.Width = this.ClientSize.Width - playerMsg.Location.X * 2; // Adjust X position for padding
            playerMsg.Height = this.ClientSize.Height - playerMsg.Location.Y * 2; // Adjust Y position for padding
        }

        private void AnimateText(object sender, EventArgs e)
        {
            // 2nd dialogue
            if (dialogueCounter == 1)
            {
                playerMsgText = "This program is crucial for our environment and public safety. We cannot delay its implementation.";
                playerName.Text = "Government Official";
            }
            // all black transition
            else if (dialogueCounter == 2)
            {
                backgroundChanger.Enabled = false;
                this.BackgroundImage = null;
                this.BackColor = Color.Black;
                playerMsgText = "";
                playerName.Text = "";
            }
            // wide view of the government talking
            else if (dialogueCounter == 3)
            {
                this.BackgroundImage = Properties.Resources.government_talking;
                playerMsgText = "";
                playerName.Text = "";
            }
            // left convo government
            else if (dialogueCounter == 4)
            {
                this.BackgroundImage = Properties.Resources.politics_left;
                playerMsgText = "These new jeepneys are a lucrative business opportunity. We need to ensure this program goes through.";
                playerName.Text = "Government Official";
            }
            // right convo government
            else if (dialogueCounter == 5)
            {
                this.BackgroundImage = Properties.Resources.politics_right;
                playerMsgText = "Don't worry, we have the support of key officials.";
                playerName.Text = "Government Official";
            }
            // all black
            else if (dialogueCounter == 6)
            {
                this.BackgroundImage = null;
                this.BackColor = Color.Black;
                playerMsgText = "";
                playerName.Text = "";
            }
            // all black
            else if (dialogueCounter == 7)
            {
                this.BackgroundImage = null;
                this.BackColor = Color.Black;
                playerMsgText = "To Be Continued";
                playerName.Text = "";
            }

            if (msgIndex < playerMsgText.Length)
            {
                if (dialogueCounter == 7)
                {
                    endLabel.Visible = true;
                    endLabel.Text += playerMsgText[msgIndex];
                }
                else playerMsg.Text += playerMsgText[msgIndex];
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
                    this.MouseClick += MouseClick_Part2; // Remove the MouseClick_Part1 event handler
                }
            });
        }

        // 3rd dialogue (only transitional, no text, black background only)
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

            // Ensure text wraps when dialogue exceeds form size
            playerMsg.AutoSize = false;
            playerMsg.Width = this.ClientSize.Width - playerMsg.Location.X * 2; // Adjust X position for padding
            playerMsg.Height = this.ClientSize.Height - playerMsg.Location.Y * 2; // Adjust Y position for padding

            // Add MouseClick_Part2 event handler after the protagonist's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part2; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part3; // Remove the MouseClick_Part1 event handler
                }
            });
        }

        // 4th dialogue (wide view of the government officials)
        private void MouseClick_Part3(object sender, MouseEventArgs e)
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
                    this.MouseClick -= MouseClick_Part3; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part4; // Remove the MouseClick_Part1 event handler
                }
            });
        }

        // 5th dialogue (left convo)
        private void MouseClick_Part4(object sender, MouseEventArgs e)
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
                    this.MouseClick -= MouseClick_Part4; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part5; // Remove the MouseClick_Part1 event handler
                }
            });
        }
        // 6th dialogue (left convo)
        private void MouseClick_Part5(object sender, MouseEventArgs e)
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
                    this.MouseClick -= MouseClick_Part5; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part6; // Remove the MouseClick_Part1 event handler
                }
            });
        }

        // 7th dialogue (all black)
        private void MouseClick_Part6(object sender, MouseEventArgs e)
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
                    this.MouseClick -= MouseClick_Part6; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part7; // Remove the MouseClick_Part1 event handler
                }
            });
        }
        // 8th dialogue (to be continued)
        private void MouseClick_Part7(object sender, MouseEventArgs e)
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

        private void backgroundChanger_Tick(object sender, EventArgs e)
        {
            caseSwitch++;
            switch (caseSwitch)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.news1;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.news2;
                    break;
            }

            if (caseSwitch == 2) caseSwitch = 0;
        }

        private void beforeTextAppears_Tick(object sender, EventArgs e)
        {
            // none
        }
    }
}