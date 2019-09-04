using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainEntities
{
    class Teme
    {
        public   String name { get; set;}
        public String description { get; set;}
        public Teme(String name, String description)
        {
            this.name = name;
            this.description = description;
        }
        public Boolean isTeme(String name)
        {
            return this.name.Equals(name);
        }
    }
}
