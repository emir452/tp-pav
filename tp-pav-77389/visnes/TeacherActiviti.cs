using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistence;
using domainEntities;
namespace visnes
{
     public class TeacherActiviti
    {
        public Sesion sesion { get; set; }
        private TeacherDao helper;
        public TeacherActiviti( Sesion sesion)
        {
            this.sesion = sesion;
}
        public Student findStudentById(int id)
        {
            return new StudentDao().findById(id);
}
        public void registerClass(Class c)
        {


        }

    }
}
