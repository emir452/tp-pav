using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using entity_builder;
using domainEntities;
namespace persistence
{
     public class TemeDao : ITemeDao
    {
        private IDatabaseConnection connection;
        private TemeBuilder builder;
        public TemeDao()
        {
            connection = DataBaseConnection.getInstance();
            builder = new TemeBuilder();
        }
        public  void registerTeme(Teme teme)
{
            String sql = "insert into temas values(" + teme.name + ", " + teme.description + ")";
            connection.executeDml(sql);
}
        public List<Teme> getAll()
        {
            List<Teme> temes = new List<Teme>();
            String sql = "select * from temas";
            DataTable results = connection.executeQueri(sql);
            foreach (DataRow i in results.Rows)
            {
                temes.Add(builder.parseTeme(i));


}
            return temes;
        }
        public Teme findById( int id)
        {
            String sql = "select * from temas t where t.id=" + id.ToString();
            return builder.parseTeme(connection.executeQueri(sql).Rows[0]);


        }

    }
}
