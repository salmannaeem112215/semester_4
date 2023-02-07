using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class AdminPref : Form
    {
        public AdminPref()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbCampus.Text == "" || cbDepartment.Text == ""|| cbProgram.Text == "")
            {
                MessageBox.Show("Please Fill All values");
                return;
            }

            DTO dto  = new DTO();
            dto.Campus = cbCampus.Text;
            dto.Department = cbDepartment.Text;
            dto.Program = cbProgram.Text;

            DL.addadminpref(dto);
            MessageBox.Show("Data Added Succesfully");
            cbCampus.Text = "";
            cbDepartment.Text = "";
            cbProgram.Text = "";

        }

        private void AdminPref_Load(object sender, EventArgs e)
        {

        }
    }
}
