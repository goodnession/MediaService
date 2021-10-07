using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaService
{
    class DB
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MediaServiceDB"].ConnectionString;

        SqlConnection sqlConnection = new SqlConnection(connectionString);

        public void openConnetion()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void closeConnetion()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
