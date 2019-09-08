using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visnes
{
    public class Role
    {
        public  enum Roles
        {
            MANAGER,
            TEACHER,
            STUDENT,
        }
        public int MyProperty { get; set; }
    }
}
