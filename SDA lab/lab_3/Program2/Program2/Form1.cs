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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ServiceReference1.Service1Client myserver = new ServiceReference1.Service1Client();
                // Delete Every Selected Row
                for(int i=0; i<dataGridView1.SelectedRows.Count; i++)
                    myserver.deletePost(dataGridView1.SelectedRows[i].Index); 
                datashow();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                ServiceReference1.Service1Client server = new ServiceReference1.Service1Client();
                ServiceReference1.Blogpost mypost = new ServiceReference1.Blogpost();
                int index = this.dataGridView1.SelectedRows[0].Index;
                mypost = server.getPost(index);
                EditForm form = new EditForm(mypost,index);
                form.Show();
                this.Hide();
            }
        }
    }
}