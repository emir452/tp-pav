using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;
namespace persistence
{
    class TeacherDao : IDao<Teacher>
    {
        private bd_alumnosEntities1 db;
        public TeacherDao()
        {
            db = new bd_alumnosEntities1();

        }
    public Teacher findById(int id)
        {
            return  db.Profesores.Find(id);
        }
        public List<Teacher> selectAll()
        {
            return  db.Profesores.ToList();
        }
        public void update(Teacher teacher)
        {
       
                }
        public void delete(int id)
        {
            db.Profesores.Remove(id);
        }
        public void add(Teacher teacher)
        {
            db.Profesores.Add(teacher);

        }
        }
}
