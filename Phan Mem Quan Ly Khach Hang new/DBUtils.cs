using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Phan_Mem_Quan_Ly_Khach_Hang_new
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "149.28.18.227";
            int port = 3306;
            string database = "QL_KH";
            string username = "root";
            string password = "";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
