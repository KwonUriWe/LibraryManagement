using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement
{
    class QueryMain
    {
        //대여 쿼리
        public static string Query_Borrow(string userId, string isbn, string bookName)
        {
            try
            {
                if (Query_checkBrwng(isbn)) //대여 여부 참
                {
                    return "대여 중인 도서.";
                }
                else
                {
                    ConnDB.ConnectDB();
                    string sqlcommand = "Update Books " +
                                        "set userId = @p1, userName = @p2, isBorrowed = 1, BorrowedAt = GETDATE() where Isbn = @p4";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", int.Parse(userId));
                    cmd.Parameters.AddWithValue("@p2", Query_userName(userId));
                    cmd.Parameters.AddWithValue("@p4", isbn);
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    string content = "사용자 : " + Query_userName(userId) + ". \nisbn : " + isbn + ". \n대여 완료. ";

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
        public static string Query_Return(string userId, string isbn, string bookName)
        {
            try
            {
                string content = null;

                if (Query_checkBrwng(isbn)) //대여 여부 참
                {
                    ConnDB.ConnectDB();

                    if (Query_checkOvrd(isbn, userId) == -1)
                    {
                        ConnDB.conn.Close();
                        return "사용자와 대여자 정보 불일치.";
                    }
                    else if (Query_checkOvrd(isbn, userId) > 7)
                    {
                        content = "사용자 : " + Query_userName(userId) + ". \nisbn : " + isbn + ". \n반납 완료. " + Query_checkOvrd(isbn, userId) + "일 연체되었습니다.";
                    }
                    else
                    {
                        content = "사용자 : " + Query_userName(userId) + ". \nisbn : " + isbn + ". \n반납 완료.";
                    }

                    string sqlcommand = "Update Books " +
                                        "set userId = null, userName = null, isBorrowed = 0, BorrowedAt = null where Isbn = @p1 and userId = @p2";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", isbn);
                    cmd.Parameters.AddWithValue("@p2", int.Parse(userId));
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    ConnDB.conn.Close();
                    return content;
                }
                else
                {
                    return "대여 중인 도서가 아님.";
                }
            }
            catch (Exception e)
            {
                return "존재하지 않는 도서 또는 사용자.";
            }
        }

        //사용자 ID에 대한 사용자 이름 확인 쿼리
        public static string Query_userName(string userId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Users Where Id = @p1";
            cmd.Parameters.AddWithValue("@p1", int.Parse(userId));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");

            string uName = ds.Tables[0].Rows[0]["Name"].ToString();

            return uName;
        }

        //도서 대여 여부 확인 쿼리
        public static bool Query_checkBrwng(string isbn)
        {
            ConnDB.ConnectDB();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = ConnDB.conn;
            cmd1.CommandText = "Select * From Books Where Isbn = @p1";
            cmd1.Parameters.AddWithValue("@p1", isbn);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            bool checkBrwng = bool.Parse(ds.Tables[0].Rows[0]["isBorrowed"].ToString());

            ConnDB.conn.Close();

            return checkBrwng;
        }
        
        //연체 여부 확인 쿼리
        public static int Query_checkOvrd(string isbn, string usrId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConnDB.conn;
                cmd.CommandText = "Select * From Books Where Isbn = @p1 and UserId = @p2";
                cmd.Parameters.AddWithValue("@p1", isbn);
                cmd.Parameters.AddWithValue("@p2", usrId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Books");

                DateTime borrowedAt = Convert.ToDateTime(ds.Tables[0].Rows[0]["borrowedAt"]);
                TimeSpan timeDiff = DateTime.Now - borrowedAt;
                int checkOvrd = timeDiff.Days;

                return checkOvrd;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        //라벨에 개수 띄우는 쿼리
        public static string Query_count(string want)
        {
            try
            {
                ConnDB.ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConnDB.conn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                switch (want)
                {
                    case "all":
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

                    case "ovrd":
                        cmd.CommandText = "Select * From  Books where datediff(dd, CONVERT(date, BorrowedAt), CONVERT(date, GETDATE())) > 7 and isBorrowed = 1";
                        da.Fill(ds, "Books");
                        break;
                }

                int count = ds.Tables[0].Rows.Count;

                ConnDB.conn.Close();

                return count.ToString();
            }
            catch (Exception)
            {
                return "오류";
            }
        }

    }
}
