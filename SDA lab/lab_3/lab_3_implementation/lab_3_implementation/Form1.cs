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

            Student 
        }
    }
}