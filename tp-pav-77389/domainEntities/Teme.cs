using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainEntities
{
    class Teme
    {
        private String name;
        private String description;
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
