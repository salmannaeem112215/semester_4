using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] users = new string[10] { "salman", "naeem", "sadiq", "farjad", "waseem", "nouman", "ahmed", "usama", "jutt", "moeez" };
            string[] passwords = new string[10] { "salman", "naeem", "sadiq", "farjad", "waseem", "nouman", "ahmed", "usama", "jutt", "moeez" };
        
            for(int i = 0; i < 10; i++)
            {
                if (textBox1.Text == users[i] && textBox2.Text == passwords[i])
                {
                    label3.BackColor = System.Drawing.Color.Green;
                    label3.Text = "Validate User";
                    break;
                }
                else
                {
                    label3.BackColor = System.Drawing.Color.Red;
                    label3.Text = "Invalid User";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
