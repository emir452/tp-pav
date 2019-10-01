using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using domainEntities;
namespace persistence
{
    public class ManagerDao : IDao<Manager>
    {
        private DataBaseConnection connection;
        private ObjectBuilder parser;
        public ManagerDao()
        {
            connection = DataBaseConnection.getInstance();
            parser = new ObjectBuilder();
        }
        public void add(Manager manager)
        {

        }
        public Manager findById(int id)
        {
            String sql = "select * from administradores a where a.id="+id;
            return parser.parseManager(connection.executeQueri(sql).Rows[0]);

        }
        public List<Manager> selectAll()
        {
            string sql = "select * from administradores";
            List<Manager> results = new List<Manager>();
            DataTable table = connection.executeQueri(sql);
            foreach (DataRow i in table.Rows)
            {
                results.Add(parser.parseManager(i));
            }
            return results;
        }
        public void update(Manager manager)
        {

        }
        public void delete(int id)
        {


        }
    }
}