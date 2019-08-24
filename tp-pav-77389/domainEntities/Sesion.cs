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
        private System.DateTime from;
        private System.DateTime to;
        private static  Sesion instance;
        public static Sesion open(User u)
        {
            if ( instance!=null)
            {
                instance = new Sesion(user);
            }
            return instance;


        }
        private Sesion(User user)
        {
            this.user = user;
            from = System.DateTime.Now;
}
        public void close()
        {
        }
        public int MyProperty { get; set; }
    }
}
