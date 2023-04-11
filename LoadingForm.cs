using Loader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasylTirsilik
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            API.Save();
        }

        private void categorize_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            categorize.Visible = false;
            progressBar.Maximum = 100000;
            progressBar.Step = 1;
            
            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j);
                progressBar.PerformStep();
            }
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
