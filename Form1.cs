using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raktarkezelo
{
    public partial class Form1 : Form
    {
        int probalkozasok = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.Text == "admin" && Password.Text == "1234")
            {
                this.Hide();
                Main foAblak = new Main();
                foAblak.Show();
            }
            else
            {
                User.Clear();
                Password.Clear();
                probalkozasok++;
                if (probalkozasok == 3)
                {
                    MessageBox.Show("le lettél tiltva öcsi");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Hibás adatok! \n Még ennyi probalkozasod van {3 - probalkozasok}");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }
    }
}
