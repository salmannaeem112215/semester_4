using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_implementation
{
    internal class Student
    {
        private string username;
        private string password;
        private string selectAge;
        private string selectGender;
        private string fileContent;
        private System.Drawing.Image fss;
        private string imagePath;

        public string UserName
        {
            get { return username; }
            set { username = value; }  
        }

        public string PassWord
        {
            get { return password; }    
            set { password = value; }   
        }

        public string SelectAge {
            set
            {
                selectAge = value;
            }
            get { return selectAge; }
        }

        public string SelectGender
        {
            get { return selectGender; }
            set { selectGender= value; }
        }
        public string FileContent
        {
            get { return fileContent; }
            set { fileContent = value; }
        }
    }
}
