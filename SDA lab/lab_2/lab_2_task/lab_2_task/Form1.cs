namespace lab_2_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void program1_Click(object sender, EventArgs e)
        {
            Program1 form = new Program1();
            form.ShowDialog();
        }

        private void program2_Click(object sender, EventArgs e)
        {
            Program2 form = new Program2();
            form.ShowDialog();

        }

        private void program3_Click(object sender, EventArgs e)
        {
            Program3 form = new Program3();
            form.ShowDialog();
        }

        private void program4_Click(object sender, EventArgs e)
        {
            Program4 form = new Program4();
            form.ShowDialog();
        }
    }
}