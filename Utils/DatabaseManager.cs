using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_assignment.Utils
{
   public static class DatabaseManager
    {
        private static readonly Lazy<SqlConnection> _connection = new Lazy<SqlConnection>(() =>
        {
            string conString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
           return con;
        });

  

        
    }
}
