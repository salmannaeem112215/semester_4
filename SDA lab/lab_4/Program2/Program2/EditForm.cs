using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private int index;
        private ServiceReference1.Blogpost editpost = new ServiceReference1.Blogpost();
        private ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();

        public EditForm(ServiceReference1.Blogpost post,int a )
        {
            InitializeComponent();
            editpost = post;
            txtPostTitle.Text = post.PostTitle;
            txtDescription.Text = post.PostDescription;
            cbApprovedPoint.Checked = post.PostApproved;
            index = a;
           }
        private void btnSave_Click(object sender, EventArgs e)
        {
            editpost.PostTitle = txtPostTitle.Text;
            editpost.PostDescription = txtDescription.Text;
            editpost.PostApproved = cbApprovedPoint.Checked;
            server.savePost(editpost, index);
            this.Close();
            Form1 firstForm = new Form1();
            firstForm.Show();
            


        }
    }
}
