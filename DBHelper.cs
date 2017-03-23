using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyQQ
{
    //数据库帮助类，维护数据库连接字符串和数据库连接对象
    class DBHelper
    {
        private static string connString = "data Source=.;Initial Catalog=MyQQ;User ID=sa;Pwd=sa";
        public static SqlConnection connection = new SqlConnection(connString);
    }
}
