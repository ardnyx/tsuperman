namespace TsuperMan
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectChar sc = new SelectChar(Form1Pnl);
            sc.TopLevel = false;
            sc.FormBorderStyle = FormBorderStyle.None;
            sc.Dock = DockStyle.Fill;
            Form1Pnl.Controls.Add(sc);
            sc.BringToFront();
            sc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Form1Pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}