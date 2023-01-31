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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        void clearTextBoxes()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""&& textBox2.Text == "")
            {
                MessageBox.Show("Please Complete Details");
                return;
            }

            StudentDTO std = new StudentDTO();
            std.name = textBox1.Text;
            std.password = textBox2.Text;
            std = StudentDL.isValidUser(std);

            if (std != null)
            {
                frmAge formAge = new frmAge("" + std.age);
                formAge.Show();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Enter Complete Data");
                return;
            }

            StudentDTO std = new StudentDTO();
            std.name = textBox1.Text;
            std.password = textBox2.Text;
            std.age = Int32.Parse(textBox3.Text);
            StudentDL.addUsers(std);

            MessageBox.Show("User Registered Succesfully");
            clearTextBoxes();
            

            if (std != null)
            {
                frmAge formAge = new frmAge("" + std.age);
                formAge.Show();
            }
        }
    }
}
