using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;
namespace visnes
{
 public     class User
    {
        public Person personalData { get; set; }
        public Role.Roles role { get; set; }
        public User( Person personalData, Role.Roles role)
        {
            this.role = role;
            this.personalData = personalData;
        }

    }
}
