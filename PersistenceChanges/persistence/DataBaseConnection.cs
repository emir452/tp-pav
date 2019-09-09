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
        private SqlConnection connection;
        private SqlCommand executor;

        private static DataBaseConnection instance = new DataBaseConnection();
        private DataBaseConnection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-HLQHQ7QSQLEXPRESS;Initial Catalog=bd_alumnos;Integrated Security=True";
         executor= new SqlCommand();
            executor.Connection = connection;
    }
        public static DataBaseConnection getInstance()
        {
            if (instance !=null)
            {
                instance = new DataBaseConnection();
           }
            return instance;
        }
        public  DataTable executeQueri(String sql)
        {
            this.openConnection();
            executor.Connection = connection;
            executor.CommandText = sql;
            DataTable table = new DataTable();
            table.Load(executor.ExecuteReader());
            this.closeConnection();
            return table;
        }
        public int executeDml(String sql )
        {
            executor.CommandText = sql;
            int queriResult = executor.ExecuteNonQuery();
            this.closeConnection();
            return queriResult;
}
        public DataTable executeQueri(string sql, object[] parameters)
        {
            DataTable table = new DataTable();
            executor.CommandText = sql;
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] != null)
                { 
                    executor.Parameters.AddWithValue((i + 1).ToString(), parameters[i])
}
}
            table.Load(executor.ExecuteReader());
            return table;
}
private void openConnection()
        {
try
            {
                connection.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
}
        private void closeConnection()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
