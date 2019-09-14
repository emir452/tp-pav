using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visnes
{
    public abstract  class Role
    {
        public  enum Roles
        {
            MANAGER,
            TEACHER,
            STUDENT,
        }
        public int MyProperty { get; set; }
        public abstract Sesion login(int id, string pasword);
    }
    }
