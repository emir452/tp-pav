using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistence;
using domainEntities;
using visnes.exceptions;

namespace visnes
{
     public class LoggerManager : Role
    {
        override
        public Sesion login(int id, string password)
{
            ManagerDao helper = new ManagerDao();
            Manager manager = helper.findById(id);
            if (manager==null)
            {
                throw new ObjectNotFoundException();
            }
            if (manager.password.Equals(password))
            {
                return new Sesion(new User(manager,Roles.MANAGER));
}
            throw new ObjectNotFoundException();
}

    }
}
