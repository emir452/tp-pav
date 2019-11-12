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
            String sql= "insert into clases values "

}
    }
}
