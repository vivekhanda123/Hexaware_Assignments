using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.DatabaseLayer
{
    public static class DBUtil
    {
        public static SqlConnection getDBConnection()
        {
            SqlConnection conn;
            string connectionstring = "Data Source=VIVEK21\\SQLEXPRESS;Initial Catalog=CourierDB;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection();
            conn.ConnectionString = connectionstring;
            return conn;
        }
    }
}
