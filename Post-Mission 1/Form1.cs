namespace Post_Mission_1
{
    public partial class Form1 : Form
    {
        private int dialogueCounter = 0;
        private int msgIndex = 0;
        private string MsgText = "Hey guys! I'm back from handing out all the flyers!";
        private System.Windows.Forms.Timer animationTimer;
        private bool isLivingRoomShown = false; // Add this flag

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.MouseClick += new MouseEventHandler(MouseClick_Part1);
        }

        /* panels have the corresponding names:
        firstDialogue              Name1
        firstDialogue_Companion    Message1

        secondDialogue             Name2
        secondDialogue_Companion   Message2

        thirdDialogue              Name3
        thirdDialogue_Companion    Message3
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            Name1.Text = "Protagonist";
            Message1.Text = string.Empty;

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();
        }

        private void AnimateText(object sender, EventArgs e)
        {
            //start of 2nd dialogue
            if (dialogueCounter == 1)
            {
                secondDialogue.Visible = true;

                firstDialogue.Visible = false;
                firstDialogue_Companion.Visible = false;

                Name2.Text = "Father";
                MsgText = "Good job, anak. But this is just the beginning. We need more support.";
            }
            //third dialogue
            else if (dialogueCounter == 2)
            {
                secondDialogue.Visible = false;

                thirdDialogue.Visible = true;
                thirdDialogue_Companion.Visible = true;

                Name3.Text = "Protagonist";
                MsgText = "I agree dad! I'm going to rest alrady. Good bye!";
            }
            else if (dialogueCounter == 3 && !isLivingRoomShown)
            {
                isLivingRoomShown = true;
                PM1_LivingRoom pM1_LivingRoom = new PM1_LivingRoom();
                pM1_LivingRoom.Show();
                this.Hide();
            }
            if (msgIndex < MsgText.Length)
            {
                if (dialogueCounter == 0)
                {
                    Message1.Text += MsgText[msgIndex];
                }
                else if (dialogueCounter == 1)
                {
                    Message2.Text += MsgText[msgIndex];
                }
                else if (dialogueCounter == 2)
                {
                    Message3.Text += MsgText[msgIndex];
                }
                msgIndex++;
            }
            else
            {
                animationTimer.Stop();
            }
        }

        // start of 2nd dialogue
        private void MouseClick_Part1(object sender, MouseEventArgs e)
        {
            dialogueCounter++; // dialogueCounter = 1
            Message2.Text = string.Empty;

            // Start animation for the father's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();

            // Add MouseClick_Part2 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part1; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part2; // Add the MouseClick_Part2 event handler
                }
            });
        }

        // 3rd dialogue
        private void MouseClick_Part2(object sender, MouseEventArgs e)
        {
            dialogueCounter++; // dialogueCounter = 2
            Message3.Text = string.Empty;

            // Start animation for the father's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();

            // Add MouseClick_Part2 event handler after the father's dialogue animation is complete
            animationTimer.Tick += new EventHandler((s, args) =>
            {
                if (!animationTimer.Enabled)
                {
                    this.MouseClick -= MouseClick_Part2; // Remove the MouseClick_Part1 event handler
                    this.MouseClick += MouseClick_Part3; // Add the MouseClick_Part2 event handler
                }
            });
        }

        // 3rd dialogue
        private void MouseClick_Part3(object sender, MouseEventArgs e)
        {
            dialogueCounter++; // dialogueCounter = 3
            Message3.Text = string.Empty;

            // Start animation for the father's dialogue
            msgIndex = 0;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 100; // Adjust the speed of the text animation
            animationTimer.Tick += new EventHandler(AnimateText);
            animationTimer.Start();
        }
    }
}