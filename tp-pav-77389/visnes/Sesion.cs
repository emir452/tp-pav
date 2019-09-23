using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visnes
{
     public class Sesion
    {
         public User user { get; set;}
        private DateTime date { get;}
        public  Sesion(User user)
        {
            this.user = user;
            date = DateTime.Now;
        }
    }
}
