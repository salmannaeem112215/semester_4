namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client(); 
            ServiceReference1.Blogpost mypost = new ServiceReference1.Blogpost();
            mypost.PostTitle = txtPostTitle.Text;
            mypost.PostDescription = txtDescription.Text;
            mypost.PostApproved = cbApprovedPoint.Checked;

            myserver.addPost(mypost);
            datashow();

        }
        void datashow()
        {
            ServiceReference1.Service1Client myclient = new ServiceReference1.Service1Client();
            BindingSource abc  = new BindingSource();
            abc.DataSource = myclient.getPosts();
            dataGridView1.DataSource = abc;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datashow();
        }
    }
}