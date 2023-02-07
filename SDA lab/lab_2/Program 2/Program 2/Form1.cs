namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] username = new string[10];
        string[] password = new string[10];
        int u = 0; // max 10

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < u; i++)
            {
                if (username[i] == txtUserName.Text)
                {
                    if (password[i] == txtPassword.Text)
                    {
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                    break;
                }
            }

            if (found)
            {
                lValidity.Text = "Is Valid";
                lValidity.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                lValidity.Text = "Is Invalid";
                lValidity.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (u<10 && txtSUsername.Text!="" && txtSPassword.Text!="" )
            {
            username[u] = txtSUsername.Text;
            password[u] = txtSPassword.Text;
            u++;
                MessageBox.Show("Succesfully Added");
            }
        }
    }
}