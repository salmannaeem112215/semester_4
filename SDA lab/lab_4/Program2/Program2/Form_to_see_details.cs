﻿using System;
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
    public partial class Form_to_see_details : Form
    {
        ServiceReference1.Blogpost show = new ServiceReference1.Blogpost();
        public Form_to_see_details()
        {
            InitializeComponent();
        }
        public Form_to_see_details(ServiceReference1.Blogpost post) 
        {
            InitializeComponent();
            show = post;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form_to_see_details_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = show.PostTitle;
            linkLabel2.Text = show.PostDescription;
        }
    }
}
