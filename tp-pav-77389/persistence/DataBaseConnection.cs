using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace persistence
{
    public class DataBaseConnection : IDatabaseConnection
    {
        private static DataBaseConnection instance = new DataBaseConnection();
        private SqlCommand executor;
        private SqlConnection connection;
        private DataBaseConnection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-HLQHQ7Q SQLEXPRESS;Initial Catalog=bd_alumnos;Integrated Security=True";
            executor = new SqlCommand();
            executor.Connection = connection;
        }
        public static DataBaseConnection getInstance()
        {
            if (instance != null)
            {
                instance = new DataBaseConnection();
            }
            return instance;
        }
         public int executeDml(string sql)
        {
            this.openConnection();
            executor.CommandText = sql;
            int result = executor.ExecuteNonQuery();
            this.closeConnection();
            return result;
        }
        public int  executeDml(string sql, Object[] parameters)
        {
            string n_param = "";
            for (int i = 0; i < parameters.Length; i++)
            { 
                if (parameters[i] != null)
                {
                    n_param = "param" + Convert.ToString(i + 1);
                    executor.Parameters.AddWithValue(n_param, parameters[i]);
}
}
            int result = executor.ExecuteNonQuery();
            this.closeConnection();
            return result;
    }
public DataTable executeQueri(String sql, Object[] parameters)
    {
        string n_param = "";
            this.openConnection();
        for (int i = 0; i < parameters.Length; i++)
        {
            if (parameters[i] != null)
            {
                n_param = "param" + Convert.ToString(i + 1);
                executor.Parameters.AddWithValue(n_param, parameters[i]);
            }
        }
        DataTable results = new DataTable();
results.Load(executor.ExecuteReader());
            this.closeConnection();
            return      results;
    }

public DataTable executeQueri(String sql)
        {
            this.openConnection();
            executor.CommandText = sql;
            DataTable table = new DataTable();
            table.Load(executor.ExecuteReader());
            this.closeConnection();
            return table;
        }
        public Boolean  executeTransaction(List<String> commands)
        {
            this.openConnection(); 
            SqlTransaction t = connection.BeginTransaction();
            foreach (String i in commands) 
            {
                try
                {
                    executor.CommandText = i;
                executor.ExecuteNonQuery();
                    }
                catch( Exception )
                {
                    this.closeConnection();
                    return false;
}
}
t.Commit();
            this.closeConnection();
            return true;
}
        private void openConnection()
        {
            try
            {
                ;
                connection.Open();
                executor.Connection = connection;
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
