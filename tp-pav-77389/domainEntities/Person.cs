using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domainEntities
{
    public class Person
    {
        private int id;
        private String name;
        private String surname;
        private String email;
        private DateTime virtDate;
        private int telephoneNmber;
        private int dni;
        public int MyProperty { get; set; }
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
