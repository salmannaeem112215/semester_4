using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            this.Hide();
            form.Show();
        }

        private void btnLoogin_Click(object sender, EventArgs e)
        {
            bool found = false;
            for(int i = 0; i < Class1.count; i++)
            {
                if(txtUserName.Text == (string)Class1.userName[i])
                {
                    if(txtPassword.Text == (string)Class1.password[i])
                    {
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }
            }
            if (found)
            {
                label1.Text = "IsValid";
                HomePage form = new HomePage();
                form.Show();
                this.Hide();
            }
            else
            {
                label1.Text = "Is Invalid";
            }
        }

        private void lPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
