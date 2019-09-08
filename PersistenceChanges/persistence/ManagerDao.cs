using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;
namespace persistence
{
    class ManagerDao :IDao<Manager> 
    {
        bd_alumnosEntities1 db; 
        public ManagerDao()
        {
            db = new bd_alumnosEntities1();

        }
        public void add(Manager manager)
        {
            db.administradores.Add(manager);
}
        public Manager  findById(int id)
        {
            return db.administradores.Find(id);
}
        public List<Manager> selectAll()
        {
            return db.administradores.ToList();
        }
        public void update(Manager manager)
        {
            
}
        public void delete(int id)
        {
            db.administradores.Remove(id);
            db.SaveChanges();
        }

    }
}
