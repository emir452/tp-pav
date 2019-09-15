using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistence;
using visnes.exceptions;
using domainEntities;
namespace visnes
{
     public class LoggerStudent : Role
    {
        override 
            public Sesion login(int id, String password)
        {
            StudentDao helper = new StudentDao();
            Student student = helper.findByID(id);
            if (student==null)
            {
                throw new ObjectNotFoundException();
            }
            if (student.password.Equals(password))
{
                return new Sesion(new User(student, Roles.STUDENT));
            }
            throw new ObjectNotFoundException();
}
    }
}
