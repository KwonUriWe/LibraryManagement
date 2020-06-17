using System;
using System.Data.SqlClient;

namespace LibraryManagement
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
