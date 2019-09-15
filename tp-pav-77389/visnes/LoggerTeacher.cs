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
    public class LoggerTeacher : Role
    {
        override
            public Sesion login(int id, String password)
        {
            TeacherDao helper = new TeacherDao();
            Teacher teacher = helper.findById(id);
            if (teacher == null)
            
                {
throw new ObjectNotFoundException();
                }
                if (teacher.password.Equals(password))
                {
                return new Sesion(new User(teacher, Roles.TEACHER));
}
            throw new ObjectNotFoundException();
        }
    }
}