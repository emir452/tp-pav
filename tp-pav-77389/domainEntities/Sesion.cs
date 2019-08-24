using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainEntities
{
    public class Sesion
    {
        private static User user;
        private static System.DateTime from;
        private static System.DateTime to;
        private static  Sesion instance;
        public static Sesion open(User u)
        {
            if ( instance!=null)
            {
                instance = new Sesion();
                from = DateTime.Now;
                user = u;
                
            }
            return instance;
}
        public void close()
        {
            to = DateTime.Now;
        }
        public int MyProperty { get; set; }
    }
}
