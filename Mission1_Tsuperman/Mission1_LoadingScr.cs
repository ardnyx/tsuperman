using System;
using System.Windows.Forms;

namespace Mission1_Tsuperman
{
    public partial class Mission1_LoadingScr : Form
    {

        Mission1_Flyers Mission1_Flyers;
        public Mission1_LoadingScr()
        {
            InitializeComponent();
        }

        private void Mission1_LoadingScr_Load(object sender, EventArgs e)
        {
            Mission1_Flyers = new Mission1_Flyers();
            Mission1_Flyers.Visible = false;
            this.Visible = true;
        }

        private void Mission1_Game1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startLabel_Click(object sender, EventArgs e)
        {
            Mission1_Flyers.Visible = true;
            this.Visible = false;
        }
    }
}
