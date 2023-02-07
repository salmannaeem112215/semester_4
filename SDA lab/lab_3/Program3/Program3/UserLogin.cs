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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DTO dto = new DTO();
            dto.UserCode = txtAddCode.Text;
            dto = DL.confirmuser(dto);
            if (dto != null)
            {
                StudentDataPanel stdp = new StudentDataPanel(dto.Campus, dto.Department, dto.Program);
                stdp.Show();
            }
            else 
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}
