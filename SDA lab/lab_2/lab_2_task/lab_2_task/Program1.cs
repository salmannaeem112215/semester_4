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

        string[] users = new string[10] ;
        string[] password = new string[10];
        int u = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            

            bool found = false;
            for(int i=0; i < u; i++)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (u < 10)
            {
                if(s_username_box.Text !="" && s_password_box.Text != "")
                {
                    users[u]= s_username_box.Text;
                    password[u] = s_password_box.Text;
                    u++;
                    MessageBox.Show("User Sign In Succesfully");
                }
                else
                {
                    MessageBox.Show("Please Enter Credentials");
                }
            }
            else
            {
                MessageBox.Show("Max Accounts Reached");
            }
        }

        private void s_password_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
