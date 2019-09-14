using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainEntities
{
    public class Person
    {
        public int id { get; set; }
         public String name { get; set; }
         public String surname { get; set; }
        public String email { get; set;}
        public DateTime virtDate { get; set;}
        public int telephoneNmber { get; set;}
        public int dni { get; set;}
        public string password { get; set;} 
        public Boolean isHe(String name)
        {
            return this.name.Equals(name);
        }
        public Boolean isHe(int id)
        {
            return this.id == id;
}
}
}
