using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3_implementation
{
    public partial class LoginHomePageHome : Form
    {
        public LoginHomePageHome()
        {
            InitializeComponent();
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;   
        }

        private void LoginHomePageHome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            foreach(Student mystudent in dataStore.data) // check all the student objects in data list
            {
                ctlUserDisplay ctl1 = new ctlUserDisplay(mystudent.ImagePath,mystudent.UserName);
                flowLayoutPanel1.Controls.Add(ctl1);

                if(txtUserName.Text == mystudent.UserName)
                {
                    System.Drawing.Image img = Image.FromFile(mystudent.ImagePath);
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pictureBox1.Image = img;
                   
                }
            }
        }
    }
}
