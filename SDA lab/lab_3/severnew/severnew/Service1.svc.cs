using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace severnew
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void addPost(Blogpost post)
        {
            Datalist.datastore.Add(post);
        }

        public List<Blogpost> getPosts()
        {
            return Datalist.datastore;
        }

        public Blogpost getPost(int postId)
        {
            return Datalist.datastore[postId];
        }

        public void deletePost(int a)
        {
            Datalist.datastore.RemoveAt(a);
        }

        public void savePost(Blogpost post,int index)
        {
            Datalist.datastore.RemoveAt(index);
            Datalist.datastore.Insert(index, post);
        }



        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
