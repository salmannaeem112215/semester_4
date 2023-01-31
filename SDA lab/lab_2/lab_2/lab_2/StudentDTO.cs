using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class StudentDTO
    {
        private String name1;
        private String age1;
        private String password1;

        private String _name;
        private String _password;
        private int _age;

        public string Name
        {
            get
            {
                return name1;
            }
            set
            {
                name1 = value;
            }
        }

        public String Age
        {
            get
            {
                return age1;
            }
            set
            {
                age1 = value;
            }
        }

        public String Password
        {
            get
            {
                return password1;
            }
            set
            {
                password1 = value;
            }
        }

        public String name
        {
            get
            {
                return name;
            }
            set
            {
                _name = value;
            }
        }

       public String password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }


}
