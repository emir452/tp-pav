using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using domainEntities;
using entity_builder;
namespace persistence
{
     public class ClassDao : IClassDao
    {
        private IDatabaseConnection connection;
        public ClassDao()
        {
            connection = DataBaseConnection.getInstance();
}
        public void registerClass(Class c)
        {
            String sql = "insert into clases values" + c.student.personalData.id.ToString() + ", " + c.teacher.personalData.id.ToString() + ", " + c.teme.id.ToString() + ", " + c.date.ToString() + ", " + c.calification.ToString() + ", " + c.observations;
            List<String> l = new List<string>();
            l.Add(sql);
            connection.executeTransaction(l);

}
    }
}
