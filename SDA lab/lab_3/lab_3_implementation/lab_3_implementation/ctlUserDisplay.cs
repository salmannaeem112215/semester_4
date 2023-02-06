using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3_implementation
{
    public partial class ctlUserDisplay : UserControl
    {
        public ctlUserDisplay()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public ctlUserDisplay(string picturePath , string username)
        {
            InitializeComponent();
            label1.Text = username;
            // picture nox properites
            System.Drawing.Image img = Image.FromFile(picturePath);
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbctlDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbctlDisplay.Image = img;
        }

        private void ctlUserDisplay_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
