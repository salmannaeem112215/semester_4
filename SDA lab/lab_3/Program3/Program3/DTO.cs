using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class DTO
    {
        private string code;
        private string campus;
        private string department;
        private string program;
        private string usercode;
        private string stucampus;
        private string studepartment;
        private string stuprogram;


        public string Code { get { return code; } set { code = value; } }
        public string Campus { get { return campus; } set { campus = value; } }
        public string Department { get { return department; } set { department = value; } }
        public string Program { get { return program; } set { program = value; } }
        public string UserCode { get { return usercode; } set { usercode = value; } }
        public string Stucampus { get { return stucampus; } set { stucampus = value; } }
        public string Studepartment { get { return studepartment; } set { studepartment = value; } }
        public string Stuprogram { get { return stuprogram; } set { stuprogram = value; } }
    }
    }
