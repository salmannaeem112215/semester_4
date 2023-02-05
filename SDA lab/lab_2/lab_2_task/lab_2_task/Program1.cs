using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_task
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] users = new string[10] {"salman","naeem","sadiq","farjad","waseem","nouman","ahmed","usama","jutt","moezz" };
            string[] password = new string[10] {"salman","naeem","sadiq","farjad","waseem","nouman","ahmed","usama","jutt","moezz" };

            bool found = false;
            for(int i=0; i < 10; i++)
            {
                if (users[i] == usernameBox.Text)
                {
                    if (users[i] == passwordBox.Text)
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                message.Text = "Valid User";
                message.BackColor = System.Drawing.Color.Green;
                message.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                message.Text = "InValid User";
                message.BackColor = System.Drawing.Color.Red;
                message.ForeColor = System.Drawing.Color.White;
            }
        }

        private void message_Click(object sender, EventArgs e)
        {

        }
    }
}
