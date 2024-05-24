using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TsuperMan
{
    public partial class SelectChar : Form
    {
        private Panel parentPanel;
        public SelectChar(Panel parent)
        {
            InitializeComponent();
            parentPanel = parent;
        }

        private void Char1Btn_Click(object sender, EventArgs e)
        {
            ShowLoadingForm();
        }

        private void Char2Btn_Click(object sender, EventArgs e)
        {
            ShowLoadingForm();
        }

        private void ShowLoadingForm()
        {
            LoadingForms lf = new LoadingForms(parentPanel);
            lf.TopLevel = false;
            lf.FormBorderStyle = FormBorderStyle.None;
            lf.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(lf);
            parentPanel.Tag = lf;
            lf.BringToFront();
            lf.LoadingCompleted += LoadingForms_Completed;
            lf.Show();
            this.Close();
        }


        private void LoadingForms_Completed(object? sender, EventArgs e)
        {
            if (sender is LoadingForms lf)
            {
                parentPanel.Controls.Remove(lf);

                Scene1 scene1 = new Scene1(parentPanel);
                scene1.TopLevel = false;
                scene1.FormBorderStyle = FormBorderStyle.None;
                scene1.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(scene1);
                parentPanel.Tag = scene1;
                scene1.BringToFront();
                scene1.Show();
            }
        }

        private void CharPnl_Paint(object sender, PaintEventArgs e)
        {
            // Your painting code here, if needed.
        }

        private void SelectChar_Load(object sender, EventArgs e)
        {
            // Your load event code here, if needed.
        }
    }
}
