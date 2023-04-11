using Loader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasylTirsilik
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void categorize_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void paper_plus_Click(object sender, EventArgs e)
        {
            paperLabel.Text = Convert.ToString(Convert.ToInt32(paperLabel.Text) + 1);
        }

        private void paper_minus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(paperLabel.Text) != 0)
            {
                paperLabel.Text = Convert.ToString(Convert.ToInt32(paperLabel.Text) - 1);
            }
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(paperLabel.Text) >= 20)
            {
                pictureBox2.Visible = true;
                label5.ForeColor = Color.Black;
            }

            if (Convert.ToInt32(metalLabel.Text) >= 10)
            {
                pictureBox5.Visible = true;
                label4.ForeColor = Color.Black;
            }

            if (Convert.ToInt32(plasticLabel.Text) >= 20)
            {
                pictureBox4.Visible = true;
                label3.ForeColor = Color.Black;
            }

            if (Convert.ToInt32(glassLabel.Text) >= 15)
            {
                pictureBox3.Visible = true;
                label2.ForeColor = Color.Black;
            }
            try
            {
                API.update(Convert.ToInt32(paperLabel.Text), Convert.ToInt32(metalLabel.Text), Convert.ToInt32(plasticLabel.Text), Convert.ToInt32(glassLabel.Text));
            }

            catch
            {

            }            
        }

        private void metal_plus_Click(object sender, EventArgs e)
        {
            metalLabel.Text = Convert.ToString(Convert.ToInt32(metalLabel.Text) + 1);
        }

        private void metal_minus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(metalLabel.Text) != 0)
            {
                metalLabel.Text = Convert.ToString(Convert.ToInt32(paperLabel.Text) - 1);
            }
        }

        private void plastic_minus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(plasticLabel.Text) != 0)
            {
                plasticLabel.Text = Convert.ToString(Convert.ToInt32(plasticLabel.Text) - 1);
            }
        }

        private void plastic_plus_Click(object sender, EventArgs e)
        {
            plasticLabel.Text = Convert.ToString(Convert.ToInt32(plasticLabel.Text) + 1);
        }

        private void glass_minus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(glassLabel.Text) != 0)
            {
                glassLabel.Text = Convert.ToString(Convert.ToInt32(paperLabel.Text) - 1);
            }
        }

        private void glass_plus_Click(object sender, EventArgs e)
        {
            glassLabel.Text = Convert.ToString(Convert.ToInt32(glassLabel.Text) + 1);
        }
    }
}
