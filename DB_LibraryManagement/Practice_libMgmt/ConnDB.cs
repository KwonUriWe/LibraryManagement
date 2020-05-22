using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_libMgmt
{
    class ConnDB
    {
        public static SqlConnection conn = new SqlConnection();

        //db 연결
        public static void ConnectDB()
        {
            try
            {
                conn.ConnectionString = string.Format("Data Source=({0}); " +
                        "Initial Catalog = {1};" +
                        "Integrated Security = {2};" +
                        "Timeout = 3"
                        , "local", "MYDB1", "SSPI");
                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
            }
            catch (Exception)
            {
                //MessageBox.Show("데이터베이스 연결 실패.");
            }
        }
    }
}
