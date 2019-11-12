using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainEntities
{
     public class Teme
    {
        public int id { get; set;}
        public   String name { get; set;}
        public String description { get; set;}
        public Teme( int id, String name, String description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
        public Boolean isTeme(String name)
        {
            return this.name.Equals(name);
        }
    }
}
