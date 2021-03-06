﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement
{

    public partial class FormUser : Form
    {
        public SqlConnection conn = new SqlConnection();
      
        public FormUser()
        {
            InitializeComponent();
            Text = "사용자 관리";

            viewAllUsers();

            //사용자 추가
            button_add.Click += (sender, e) =>
            {
                string userId = textBox_id.Text;
                string userName = textBox_name.Text;

                if (textBox_id.Text.Trim() == "" || textBox_name.Text.Trim() == "")
                {
                    ShowMessage(button_add.Text, "모든 정보 입력 필요.");
                }
                else
                {
                    ShowMessage(button_add.Text, QueryUser.Query_add(userId, userName));
                    viewAllUsers();
                }
            };

            //사용자 수정
            button_modify.Click += (sender, e) =>
            {
                string userId = textBox_id.Text;
                string userName = textBox_name.Text;

                if (textBox_id.Text.Trim() == "" || textBox_name.Text.Trim() == "")
                {
                    ShowMessage(button_add.Text, "모든 정보 입력 필요.");
                }
                else
                {
                    ShowMessage(button_modify.Text, QueryUser.Query_modify(userId, userName));
                    viewAllUsers();
                }
            };

            //사용자 삭제
            button_delete.Click += (sender, e) =>
            {
                string userId = textBox_id.Text;
                string userName = textBox_name.Text;

                if (textBox_id.Text.Trim() == "" || textBox_name.Text.Trim() == "")
                {
                    ShowMessage(button_add.Text, "모든 정보 입력 필요.");
                }
                else
                {
                    ShowMessage(button_delete.Text, QueryUser.Query_delete(userId));
                    viewAllUsers();
                }
            };
        }

        //dataGridView_userlist 출력 메소드
        private void viewAllUsers()
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Users order by id desc";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Users");

            dataGridView_userlist.DataSource = ds;
            dataGridView_userlist.DataMember = "Users";

            ConnDB.conn.Close();
            return;
        }

        //DataGridView가 바뀌었을때 발생하는 이벤트
        private void DataGridView_userlist_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var temp = dataGridView_userlist.CurrentRow;
                textBox_id.Text = dataGridView_userlist.CurrentRow.Cells[0].Value.ToString();
                textBox_name.Text = dataGridView_userlist.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        //재입력 버튼 클릭
        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_name.Text = "";
        }

        //사용자 검색 버튼 클릭시 발생하는 이벤트
        private void button_sUser_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            string sUser = "%" + textBox_user.Text + "%";
            bool canConvert = int.TryParse(textBox_user.Text, out n1);

            //입력값이 숫자로 변환되는지 확인. 숫자이면 id값, 아니면 name값
            if (canConvert == true)
            {
                ConnDB.ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConnDB.conn;
                cmd.CommandText = "Select * From Users where Id like @p1 order by Id desc";
                cmd.Parameters.AddWithValue("@p1", sUser);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Users");

                dataGridView_userlist.DataSource = ds;
                dataGridView_userlist.DataMember = "Users";

                ConnDB.conn.Close();
            }
            else
            {
                ConnDB.ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConnDB.conn;
                cmd.CommandText = "Select * From Users where Name like @p1 order by Id desc";
                cmd.Parameters.AddWithValue("@p1", sUser);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Users");

                dataGridView_userlist.DataSource = ds;
                dataGridView_userlist.DataMember = "Users";

                ConnDB.conn.Close();
            }

            return;
        }

        //로그저장 메소드
        private void WriteLog(string contents)
        {
            //디렉토리 폴더가 없을 경우 폴더 생성
            DirectoryInfo di = new DirectoryInfo(@"./LogFile");
            if (!di.Exists)
            {
                di.Create();
            }

            //로그 내용 저장
            using (StreamWriter writer = new StreamWriter(@"./LogFile/Lib_user.txt", true))
            {
                writer.WriteLine(contents);
            }
        }

        //메세지박스 팝업 + 로그저장 메소드 호출
        private void ShowMessage(string clickedBtn, string showMessage)
        {
            string activeMessage = "[" + DateTime.Now.ToString() + "]  [ 사용자 관리 ]" +
                                   "  <" + clickedBtn + ">  " + showMessage;
            MessageBox.Show(showMessage);
            listBox1.Items.Insert(0, activeMessage);
            WriteLog(activeMessage);
        }
    }
}
