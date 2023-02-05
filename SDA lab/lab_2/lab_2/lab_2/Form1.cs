namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void clearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private bool isValidEntry()
        {
            bool validEntry = true;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter username");
                validEntry = false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter age");
                validEntry = false;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter password");
                validEntry = false;
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Password not matched");
                validEntry = false;
            }
            return validEntry;
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
            int total = StudentDL.getTotalRegisterStudents();
            MessageBox.Show("Total Users are = " + total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isValidEntry()) return;
            StudentDTO dto = new StudentDTO();
            dto.Name = label1.Text;
            dto.Age = label2.Text;
            dto.Password = label3.Text;
            StudentBL.register(dto);
            clearTextBoxes();
            MessageBox.Show("Register Succesfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm LoginForm = new loginForm();
            LoginForm.Show();
        }

        private void Program2_Click(object sender, EventArgs e)
        {

        }

        private void Program1_Click(object sender, EventArgs e)
        {

        }
    }
}

