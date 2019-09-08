using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;

 
namespace persistence
{
    class StudentDao : IDao<Student>
    {
       
        private bd_alumnosEntities1 db;
        public StudentDao()
        {
            db = new bd_alumnosEntities1();


        }
        public void update(Student student)
        {
            
        }
        public void add(Student student)
        {
            db.Alumnos.Add(student);
}
public void delete(int id)
    {
            db.Alumnos.Remove(id);

}
public List<Student> selectAll()
{
            return db.Alumnos.ToList();
}
}
}