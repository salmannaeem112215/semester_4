using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class StudentBL
    {
        StudentDTO dto2;
        StudentBL(StudentDTO dto2)
        {
            this.dto2 = dto2;
        }
        public static StudentBL register(StudentDTO dto2)
        {
            StudentDL.addUsers(dto2);
            StudentBL studentBL = new StudentBL(dto2);
            return studentBL;
        }
    }
}
