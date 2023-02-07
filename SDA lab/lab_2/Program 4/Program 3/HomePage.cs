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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private int k_index=-1;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int found = -1;
            for(int i=0; i < Class1.count; i++)
            {
                if(txtUserName.Text == (string)Class1.userName[i])
                {
                    found = i;
                    break;
                }
            }
            if (found != -1)
            {
                MessageBox.Show("User Found");
                k_index = found;
            }
            else
            {
                MessageBox.Show("User Not Found");

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class1.password[k_index] = txtPassword.Text;
            MessageBox.Show("Password Changed");
        }
    }
}
