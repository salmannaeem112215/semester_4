namespace lab_3_implementation
{
    public partial class Form1 : Form
    {
        string fPath;
        System.Drawing.Image fs; // Return type is image
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog= new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\Users\\Salman\\Pictures";
            fileDialog.Title = "Chose Image File";
            fileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fPath = fileDialog.FileName;
                fs = Image.FromFile(fPath);
                fs.RotateFlip(RotateFlipType.Rotate270FlipNone); // to rotate pic
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;  // to fit pic
                pictureBox1.Image = fs;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String extension = System.IO.Path.GetExtension(fPath);
            String fileName = txtUsername.Text;
            fileName += extension;
            String path = System.IO.Directory.GetCurrentDirectory();

            String pathWithName = System.IO.Path.Combine(path, fileName);

            fs.Save(pathWithName);

            Student std = new Student();
            std.UserName = txtUsername.Text;
            std.PassWord = txtPassword.Text;
            std.SelectAge = txtAge.Text;
            std.ImagePath = pathWithName;

            if (r1.Checked)
            {
                std.SelectGender = "Male";
            }
            else if(r2.Checked)
            {
                std.SelectGender = "Female";
            }
            else
            {
                std.SelectGender = "BTS";
            }

            dataStore.data.Add(std);
            MessageBox.Show("User Succesfully Added");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginHomePageHome form = new LoginHomePageHome();
            form.Show();
            this.Hide();
        }
    }
}