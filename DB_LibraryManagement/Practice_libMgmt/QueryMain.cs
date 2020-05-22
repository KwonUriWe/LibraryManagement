using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_libMgmt
{
    class QueryMain
    {
        //대여 쿼리
        public static string Query_Borrow()
        {
            try
            {
                if (Query_checkBrwng()) //대여 여부 참
                {
                    return "대여 중인 도서.";
                }
                else
                {
                    string today = DateTime.Now.ToString();
                    ConnDB.ConnectDB();
                    string sqlcommand = "Update Books " +
                                        "set userId = @p1 userName = @p2, isBorrowed = 1, BorrowedAt = @p3 where Isbn = @p4";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", int.Parse(GetSetInfrm.userId));
                    cmd.Parameters.AddWithValue("@p2", Query_userName());
                    cmd.Parameters.AddWithValue("@p3", today);
                    cmd.Parameters.AddWithValue("@p4", GetSetInfrm.isbn);
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    string content = "\"" + Query_userName() + "\"님. \"" + GetSetInfrm.bookName + "\" 대여 완료.";

                    ConnDB.conn.Close();

                    return content;
                }
            }
            catch (Exception e)
            {
                return "존재하지 않는 도서 또는 사용자.";
            }
        }

        //반납 쿼리
        public static string Query_Return()
        {
            try
            {
                if (Query_checkBrwng()) //대여 여부 참
                {
                    ConnDB.ConnectDB();
                    string sqlcommand = "Update Books " +
                                        "set userId = @p1 userName = @p2, isBorrowed = 0, BorrowedAt = @p3 where Isbn = @p4";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", 0);
                    cmd.Parameters.AddWithValue("@p2", "");
                    cmd.Parameters.AddWithValue("@p3", new DateTime());
                    cmd.Parameters.AddWithValue("@p4", GetSetInfrm.isbn);
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    string content1 = "\"" + Query_userName() + "\"님. \"" + GetSetInfrm.bookName + "\" 반납 완료. (연체)";
                    string content2 = "\"" + Query_userName() + "\"님. \"" + GetSetInfrm.bookName + "\" 반납 완료.";

                    ConnDB.conn.Close();

                    if (Query_checkOvrd() > 7)
                    {
                        return content1;
                    }
                    else
                    {
                        return content2;
                    }
                }
                else
                {
                    return "대여 중인 도서가 아님.";
                }
            }
            catch (Exception e)
            {
                return "존재하지 않는 도서/사용자.";
            }
        }

        //사용자 ID에 대한 사용자 이름 확인 쿼리
        public static string Query_userName()
        {
            //ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Users Where Id = @p1";
            cmd.Parameters.AddWithValue("@p1", int.Parse(GetSetInfrm.userId));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");

            string uName = ds.Tables[0].Rows[0]["Name"].ToString();

            //ConnDB.conn.Close();

            return uName;
        }

        //도서 대여 여부 확인 쿼리
        public static bool Query_checkBrwng()
        {
            ConnDB.ConnectDB();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = ConnDB.conn;
            cmd1.CommandText = "Select * From Books Where Isbn = @p1";
            cmd1.Parameters.AddWithValue("@p1", GetSetInfrm.isbn);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            bool checkBrwng = bool.Parse(ds.Tables[0].Rows[0]["isBorrowed"].ToString());

            ConnDB.conn.Close();

            return checkBrwng;
        }
        
        //연체 여부 확인 쿼리
        public static int Query_checkOvrd()
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Books Where Isdn = @p1";
            cmd.Parameters.AddWithValue("@p1", GetSetInfrm.isbn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            DateTime borrowedAt = Convert.ToDateTime(ds.Tables[0].Rows[0]["borrowedAt"]);
            TimeSpan timeDiff = DateTime.Now - borrowedAt;
            int checkOvrd = timeDiff.Days;

            ConnDB.conn.Close();


            return checkOvrd;
        }

        //라벨에 개수 띄우는 쿼리
        public static string Query_count(string want)
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            switch (want)
            {
                case "all" :
                    cmd.CommandText = "Select * From Books";
                    da.Fill(ds, "Books");
                    break;

                case "user":
                    cmd.CommandText = "Select * From Users";
                    da.Fill(ds, "Users");
                    break;

                case "brwd":
                    cmd.CommandText = "Select * From Books Where isBorrowed = 1";
                    da.Fill(ds, "Books");
                    break;

                //case "ovrd":
                //    cmd.CommandText = "Select * From Books";
                //    da.Fill(ds, "Books");
                //    break;
            }
            
            int count = ds.Tables[0].Rows.Count;
            
            ConnDB.conn.Close();

            return count.ToString();
        }

        ////연체 중인 도서 수
        //label_allOverdueCnt.Text = DateManager.Books.Where((x) =>
        //{
        //    return x.isBorrowed && x.BorrowedAt.AddDays(7) > DateTime.Now;
        //}).Count().ToString();
    }
}
