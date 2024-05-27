using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TsuperMan
{
    public partial class LoadingForms : Form
    {
        private System.Windows.Forms.Timer? timer;
        private Panel parentPanel;
        public event EventHandler? LoadingCompleted;

        public LoadingForms(Panel parent)
        {
            InitializeComponent();
            parentPanel = parent;
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Set the interval to 50 ms for a total of 5 seconds
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void LoadingForms_Load(object sender, EventArgs e)
        {
            Timer.Value = 0;
            timer?.Start();
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            if (Timer.Value < 100)
            {
                Timer.Value += 2; // Increment the value by 2 every 50 ms (2 * 50ms * 50 ticks = 5000ms = 5 seconds)
            }
            else
            {
                timer?.Stop();
                OnLoadingCompleted(EventArgs.Empty);
                this.Close();
            }
        }

        protected virtual void OnLoadingCompleted(EventArgs e)
        {
            LoadingCompleted?.Invoke(this, e);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
