using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace persistence
{
     public class DataBaseConnection
    {
        private static DataBaseConnection instance;
        private SqlConnection connection;
        private SqlCommand executor; 

    }
}
