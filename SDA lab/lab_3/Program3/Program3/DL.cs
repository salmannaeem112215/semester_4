using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class DL
    {
        public static ArrayList adminpref = new ArrayList();
        public static ArrayList codes = new ArrayList();
        public static ArrayList studentpref = new ArrayList();

        public static void addcodes(DTO dto)
        {
            codes.Add(dto);
        }
        public static void addadminpref(DTO ap) 
        {
             adminpref.Add(ap);
        }
        public static void addstudentpref(DTO dto)
        {
            studentpref.Add(dto);
        }
        public static DTO confirmuser(DTO dto)
        {
            foreach(DTO d in codes)
                if (d.Code.Equals(dto.UserCode))
                    return d;
            return null;
        }

}
}
