using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_task
{
    class Class1 {
        public static ArrayList userName = new ArrayList();
        public static ArrayList passWord = new ArrayList();
        public static int count;
    }

    public partial class Program3 : Form
    {
        public Program3()
        {
            InitializeComponent();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            this.Hide();
        }

        private void Program3_Load(object sender, EventArgs e)
        {

        }
    }
}
