using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Chat.server
{
    static public class Db
    {
        public static void Login(string connnectionString, string username, string password)
        {
            SqlConnection conn = new(connnectionString);
            try
            {
                if(conn.State == ConnectionState.Closed) conn.Open();
                string query = $"SELECT * FROM users WHERE Username={username} AND Password={password}";
            }
            catch(Exception ex)
            {
                conn.Close();
                throw new Exception(ex.Message);
                
            }
            
        }
    }
}
