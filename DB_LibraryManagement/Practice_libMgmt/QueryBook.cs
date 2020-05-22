using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_libMgmt
{
    class QueryBook
    {
        //추가 쿼리
        public static string Query_add()
        {
            try
            {
                if (CheckDplct() == 0)
                {
                    ConnDB.ConnectDB();
                    string sqlcommand = "Insert into Books (Isbn, Name, Publisher, Page, isBorrowed) Values (@p1, @p2, @p3, @p4, 0)";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", GetSetInfrm.isbn);
                    cmd.Parameters.AddWithValue("@p2", GetSetInfrm.bookName);
                    cmd.Parameters.AddWithValue("@p3", GetSetInfrm.publisher);
                    cmd.Parameters.AddWithValue("@p4", int.Parse(GetSetInfrm.page));
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    ConnDB.conn.Close();

                    return GetSetInfrm.isbn + " 도서 정보 추가 완료.";
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
        public static string Query_modify()
        {
            try
            {
                if (CheckDplct() == 0)
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
                    cmd.Parameters.AddWithValue("@p1", GetSetInfrm.bookName);
                    cmd.Parameters.AddWithValue("@p2", GetSetInfrm.publisher);
                    cmd.Parameters.AddWithValue("@p3", int.Parse(GetSetInfrm.page));
                    cmd.Parameters.AddWithValue("@p4", GetSetInfrm.isbn);
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    ConnDB.conn.Close();

                    return GetSetInfrm.isbn + " 도서 정보 수정 완료.";
                }
            }
            catch (Exception e)
            {
                return "DB 오류.";
            }
        }

        //삭제 쿼리
        public static string Query_delete()
        {
            try
            {
                if (CheckDplct() == 0)
                {
                    return "존재하지 않는 Isbn. Isbn값 삭제 불가.";
                }
                else
                {
                    ConnDB.ConnectDB();
                    string sqlcommand = "Delete Books where Isbn = @p1";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", GetSetInfrm.isbn);
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    ConnDB.conn.Close();

                    return GetSetInfrm.isbn + " 도서 정보 삭제 완료.";
                }
            }
            catch (Exception e)
            {
                return "DB 오류.";
            }
        }

        //Isbn 존재 여부 확인 쿼리
        public static int CheckDplct()
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Books Where Isbn = @p1";
            cmd.Parameters.AddWithValue("@p1", GetSetInfrm.isbn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            int count = ds.Tables[0].Rows.Count;

            ConnDB.conn.Close();

            return count;
        }
    }
}
