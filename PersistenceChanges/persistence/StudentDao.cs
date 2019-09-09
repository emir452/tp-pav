using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;

 
namespace persistence
{
    public  class StudentDao : IDao<Student>
    {
        private DataBaseConnection connection;
        public StudentDao()
        {
            connection = DataBaseConnection.getInstance();
        }
        public void update(Student student)
        {
            
        }
        public void add(Student student)
        {
            
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