using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;

 
namespace persistence
{
    class StudentDao :IDao<Student>
    {
        public void update (Student student)
        {
            
        }
        public void add(Student student)
        {
}
public void delete(int id)
        {

        }
        public List<Student> selectAll()
        {
            bd_alumnosEntities1 c = new bd_alumnosEntities1();
            return c.Alumnos.ToList();
        }
            
            
    }
}
