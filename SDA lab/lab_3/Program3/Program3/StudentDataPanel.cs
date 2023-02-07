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
    public partial class StudentDataPanel : Form
    {
        public StudentDataPanel(String dep, String camp, String program)
        {
            InitializeComponent();
            cbCampus.Text = camp;
            cbDepartment.Text = dep;
            cbProgram.Text = program;

        }

        private void StudentDataPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbCampus.Text=="" || cbDepartment.Text == "" || cbProgram.Text == "")
            {
                MessageBox.Show("Please Fill All Entries");
                return;
            }

            DTO dto = new DTO();
            dto.Stucampus = cbCampus.Text;
            dto.Studepartment= cbDepartment.Text;
            dto.Stuprogram = cbProgram.Text;

            DL.addstudentpref(dto);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DL.studentpref;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            cbCampus.Text = cbDepartment.Text = cbProgram.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbCampus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
