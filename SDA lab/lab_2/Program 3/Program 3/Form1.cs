namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SignUpForm form = new SignUpForm();
            this.Hide();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}