namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] users = new string[10] { "salman", "naeem", "sadiq", "farjad", "waseem", "nouman", "ahmed", "usama", "jutt", "moeez" };
            string[] passwords = new string[10] { "salman", "naeem", "sadiq", "farjad", "waseem", "nouman", "ahmed", "usama", "jutt", "moeez" };
            bool found = false;

            for(int i = 0; i < 10; i++)
            {
                if(users[i] == txtUserName.Text)
                {
                    if (passwords[i] == txtPassword.Text)
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

        private void lValidity_Click(object sender, EventArgs e)
        {

        }
    }
}