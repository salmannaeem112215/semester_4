namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // giving values
            initializeText();

        }

        private void initializeText()
        {
            //assigning values to label
            label1.Text = "Username";
            label2.Text = "Age";
            label3.Text = "Password";
            label4.Text = "Confirm Password";

            //assigning values to buttons
            button1.Text = "Total Users";
            button2.Text = "Registration";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}