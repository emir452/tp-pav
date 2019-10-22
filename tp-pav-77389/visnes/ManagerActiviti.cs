using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visnes.exceptions;
using domainEntities;
using persistence;
namespace visnes
{
    public class ManagerActiviti
    {
        private Sesion sesion;
        public ManagerActiviti(Sesion sesion)
        {
            this.sesion = sesion;
        }
        public void registerStudent(Student student)
        {
            StudentDao helper = new StudentDao();
            helper.add(student);
        }
        public void deleteStudent(int id)
        {
            StudentDao helper = new StudentDao();
            helper.delete(id);
        }
        public Student findStudentById(int id)
        {
            StudentDao helper = new StudentDao();
            try
            {
                return helper.findById(id);
            }
            catch (Exception)
            {
                throw new ObjectNotFoundException();
            }
        }
        public void updateStudent(Student s)
        {

            StudentDao updater = new StudentDao();
            try
            { 
            updater.update(s);
        }
            catch (Exception)
            {
                throw new ImposibleUpdateException();
            }
        }

        public void registerTeacher(Teacher teacher)
        {
            TeacherDao logger = new TeacherDao();
            logger.add(teacher);
        }
        public  void deleteTeacher(int id)
        {
            TeacherDao helper = new TeacherDao();
            helper.delete(id);
        }

    }
}