using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace persistence
{
     public interface IDatabaseConnection
    {
        int executeDml(string sql);
        int executeDml(String sql, Object[] parameters);
        DataTable executeQueri(String sql, Object [] parameters);
        DataTable executeQueri(String sql);
        bool executeTransaction(List<string> commands);   
    }
}
