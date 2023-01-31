using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class StudentDL
    {
        private static List<StudentDTO> students = new List<StudentDTO>()
;
        public static void addUsers(StudentDTO sdto)
        {
            students.Add(sdto);
        }
        public static int getTotalRegisterStudents()
        {
            return students.ToList().Count;
        }

        
    }
}
