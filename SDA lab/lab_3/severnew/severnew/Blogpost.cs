using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace severnew
{
    public class Blogpost
    {
        private string postTitle;
        private string postDescription;
        private string postApproved;

        public string PostTitle{ get { return postTitle; } set { postTitle = value; } } 
        public string PostDescription{ get { return postDescription; } set { postDescription = value; } }
        public string PostApproved { get { return postApproved; } set { postApproved = value; } }

    }
}