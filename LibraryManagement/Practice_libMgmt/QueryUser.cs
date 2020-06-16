using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class QueryUser
    {
        //추가 쿼리
        public static string Query_add(string userId, string userName)
        {
            try
            {
                if (CheckDplct(userId) == 0)
                {
                    ConnDB.ConnectDB();
                    string sqlcommand = "Insert into Users (Id, Name) Values (@p1, @p2)";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", int.Parse(userId));
                    cmd.Parameters.AddWithValue("@p2", userName);
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    ConnDB.conn.Close();

                    return userId + " 사용자 정보 추가 완료.";
                }
                else
                {
                    return "중복되는 Id. \"" + Query_nextId() + "\"로 입력 바람.";
                }
            }
            catch (Exception)
            {
                return "DB 오류";
            }

        }

        //수정 쿼리
        public static string Query_modify(string userId, string userName)
        {
            try
            {
                if (CheckDplct(userId) == 0)
                {
                    return "존재하지 않는 Id. Id값 수정 불가.";
                }
                else
                {
                    ConnDB.ConnectDB();
                    string sqlcommand1 = "Update Users set Name = @p1 where Id = @p2";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = ConnDB.conn;
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@p1", userName);
                    cmd1.Parameters.AddWithValue("@p2", userId);
                    cmd1.CommandText = sqlcommand1;
                    cmd1.ExecuteNonQuery();

                    string sqlcommand2 = "Update Books set UserName = @p1 where UserId = @p2";
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = ConnDB.conn;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("@p1", userName);
                    cmd2.Parameters.AddWithValue("@p2", userId);
                    cmd2.CommandText = sqlcommand2;
                    cmd2.ExecuteNonQuery();

                    ConnDB.conn.Close();

                    return userId + " 사용자 정보 수정 완료.";
                }
            }
            catch (Exception e)
            {
                return "DB 오류.";
            }
        }

        //삭제 쿼리
        public static string Query_delete(string userId)
        {
            try
            {
                if (CheckDplct(userId) == 0)
                {
                    return "존재하지 않는 Id. Id값 삭제 불가.";
                }
                else if (CheckBwd(userId) > 0)
                {
                    return "대여중인 도서. 반납 후 삭제 가능.";
                }
                else
                {
                    ConnDB.ConnectDB();
                    string sqlcommand = "Delete From Users where Id = @p1";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ConnDB.conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", int.Parse(userId));
                    cmd.CommandText = sqlcommand;
                    cmd.ExecuteNonQuery();

                    ConnDB.conn.Close();

                    return userId + " 사용자 정보 삭제 완료.";
                }
            }
            catch (Exception e)
            {
                return "DB 오류.";
            }
        }

        //대여여부 확인 쿼리
        public static int CheckBwd(string userId)
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select isbn From Books Where UserId = @p1";
            cmd.Parameters.AddWithValue("@p1", userId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            int count = ds.Tables[0].Rows.Count;

            ConnDB.conn.Close();

            return count;
        }

        //id 존재 여부 확인 쿼리
        public static int CheckDplct(string userId)
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Users Where Id = @p1";
            cmd.Parameters.AddWithValue("@p1", userId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");

            int count = ds.Tables[0].Rows.Count;

            ConnDB.conn.Close();

            return count;
        }


        //저장된 마지막 Id값 확인 쿼리
        public static int Query_nextId()
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Users Order by Id desc";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");

            string nextId = ds.Tables[0].Rows[0]["id"].ToString();

            ConnDB.conn.Close();

            return int.Parse(nextId) + 1;
        }
    }
}
