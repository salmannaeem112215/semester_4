using System;
using System.Collections;
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


        // example 2
        private static ArrayList users = new ArrayList();

        public static void addStudent(StudentDTO std)
        {
            users.Add(std);
        }

        public static StudentDTO isValidUser(StudentDTO std)
        {
            foreach(StudentDTO u in users)
            {
                if(u.name.Equals(std.name) && u.password.Equals(std.password))
                {
                    return u;
                }
            }
            return null;
        }
        public static int getTotal()
        {
            return users.Count;
        }

    }
    

}
