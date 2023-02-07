namespace Program3
{
    public partial class btnShow : Form
    {
        public btnShow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO dto = new DTO();
            dto.Code = txtAddCode.Text;

            if(txtAddCode.Text != "")
            {
                DL.addcodes(dto);

                codesLayout.DataSource = null;
                codesLayout.DataSource = DL.codes;

                codesLayout.Columns[1].Visible = false;
                codesLayout.Columns[2].Visible = false;
                codesLayout.Columns[3].Visible = false;
                codesLayout.Columns[4].Visible = false;
                codesLayout.Columns[5].Visible = false;
                codesLayout.Columns[6].Visible = false;
                codesLayout.Columns[7].Visible = false;

                txtAddCode.Text = "";
            }
            else
            {
                MessageBox.Show("Please Fill All values");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin form = new UserLogin();
            form.Show();
        }

        private void codesLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPref form = new AdminPref();
            form.Show();
        }
    }
}