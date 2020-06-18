using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement
{
    class QueryBook
    {
        //추가 쿼리
        public static string Query_add(string isbn, string bookName, string publisher, string page)
        {
            try
            {
                if (CheckDplct(isbn) == 0)
                {
                    ConnDB.ConnectDB();
                    string sqlcommand = "Insert into Books (Isbn, Name, Publisher, Page, isBorrowed) Values (@p1, @p2, @p3, @p4, 0)";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", isbn);
                    cmd.Parameters.AddWithValue("@p2", bookName);
                    cmd.Parameters.AddWithValue("@p3", publisher);
                    cmd.Parameters.AddWithValue("@p4", int.Parse(page));
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    ConnDB.conn.Close();

                    return isbn + " 도서 정보 추가 완료.";
                }
                else
                {
                    return "중복되는 Isbn.";
                }
            }
            catch (Exception e)
            {
                return "DB 오류.";
            }

        }

        //수정 쿼리
        public static string Query_modify(string isbn, string bookName, string publisher, string page)
        {
            try
            {
                if (CheckDplct(isbn) == 0)
                {
                    return "존재하지 않는 Isbn.  Isbn값 수정 불가.";
                }
                else
                {
                    ConnDB.ConnectDB();
                    string sqlcommand = "Update Books set Name = @p1, Publisher = @p2, Page = @p3 where Isbn = @p4";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", bookName);
                    cmd.Parameters.AddWithValue("@p2", publisher);
                    cmd.Parameters.AddWithValue("@p3", int.Parse(page));
                    cmd.Parameters.AddWithValue("@p4", isbn);
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    ConnDB.conn.Close();

                    return isbn + " 도서 정보 수정 완료.";
                }
            }
            catch (Exception e)
            {
                return "DB 오류.";
            }
        }

        //삭제 쿼리
        public static string Query_delete(string isbn)
        {
            try
            {
                if (CheckDplct(isbn) == 0)
                {
                    return "존재하지 않는 Isbn. Isbn값 삭제 불가.";
                }
                else if (CheckBwd(isbn) == 1)
                {
                    return "대여중인 도서. 반납 후 삭제 가능.";
                }
                else
                {
                    ConnDB.ConnectDB();
                    string sqlcommand = "Delete Books where Isbn = @p1";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", isbn);
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    ConnDB.conn.Close();

                    return isbn + " 도서 정보 삭제 완료.";
                }
            }
            catch (Exception e)
            {
                return "DB 오류.";
            }
        }

        //대여여부 확인 쿼리
        public static int CheckBwd(string isbn)
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select isbn From Books Where Isbn = @p1 and isBorrowed = 1";
            cmd.Parameters.AddWithValue("@p1", isbn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            int count = ds.Tables[0].Rows.Count;

            ConnDB.conn.Close();

            return count;
        }

        //Isbn 존재 여부 확인 쿼리
        public static int CheckDplct(string isbn)
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Books Where Isbn = @p1";
            cmd.Parameters.AddWithValue("@p1", isbn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            int count = ds.Tables[0].Rows.Count;

            ConnDB.conn.Close();

            return count;
        }
    }
}
