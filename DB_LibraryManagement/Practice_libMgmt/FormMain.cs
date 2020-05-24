using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_libMgmt
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Text = "도서관 관리_DB";

            //전체 도서 수
            label_allBookCnt.Text = QueryMain.Query_count("all");

            //사용자 수
            label_allUserCnt.Text = QueryMain.Query_count("user");

            //대출 중인 도서 수
            label_allBrwdCnt.Text = QueryMain.Query_count("brwd");

            //연체 중인 도서 수
            QueryMain.Query_count("all");
            label_allBrwdCnt.Text = QueryMain.Query_count("ovrd");

            viewAllUsers();
            viewAllBooks();
        }

        //dataGridView_user 출력 메소드
        private void viewAllUsers()
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Users";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Users");

            dataGridView_user.DataSource = ds;
            dataGridView_user.DataMember = "Users";

            ConnDB.conn.Close();
            return;
        }

        //dataGridView_book 출력 쿼리
        private void viewAllBooks()
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Books";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Books");

            dataGridView_book.DataSource = ds;
            dataGridView_book.DataMember = "Books";

            ConnDB.conn.Close();
            return;
        }

        //대여 버튼 클릭
        private void button_Borrow_Click(object sender, EventArgs e)
        {
            string userId = textBox_userID.Text;
            string isbn = textBox_Isbn.Text;
            string bookName =  textBox_bookName.Text;

            if (textBox_Isbn.Text.Trim() == "" || textBox_bookName.Text.Trim() == "" || textBox_userID.Text.Trim() == "")
            {
                ShowMessage(button_Borrow.Text, "모든 정보 입력 필요.");
            }
            else
            {
                ShowMessage(button_Borrow.Text, QueryMain.Query_Borrow(userId, isbn, bookName));
                viewAllBooks();
            }
        }

        //반납 버튼 클릭
        private void button_Return_Click(object sender, EventArgs e)
        {
            string userId = textBox_userID.Text;
            string isbn = textBox_Isbn.Text;
            string bookName = textBox_bookName.Text;

            if (textBox_Isbn.Text.Trim() == "" || textBox_bookName.Text.Trim() == "" || textBox_userID.Text.Trim() == "")
            {
                MessageBox.Show("모든 정보 입력 필요.");
            }
            else
            {
                ShowMessage(button_Return.Text, QueryMain.Query_Return(userId, isbn, bookName));
                viewAllBooks();
            }
        }

        //도서관리 메뉴 클릭
        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormBook().ShowDialog();
            viewAllBooks();
        }

        //사용자관리 메뉴 클릭
        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUser().ShowDialog();
            viewAllUsers();
        }

        //DataGridView_user이 바뀌었을때 발생하는 이벤트
        private void DataGridView_user_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var temp = dataGridView_user.CurrentRow;
                textBox_userID.Text = dataGridView_user.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        //DataGridView_book이 바뀌었을때 발생하는 이벤트
        private void DataGridView_book_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var temp = dataGridView_book.CurrentRow;
                textBox_Isbn.Text = dataGridView_book.CurrentRow.Cells[0].Value.ToString();
                textBox_bookName.Text = dataGridView_book.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        //재입력 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Isbn.Text = "";
            textBox_userID.Text = "";
            textBox_bookName.Text = "";
        }
        
        //로그저장 메소드
        private void WriteLog(string contents)
        {
            using (StreamWriter writer = new StreamWriter(@"./Log_LibraryManagement.txt", true))
            {
                writer.WriteLine(contents);
            }
        }

        //메세지박스 팝업 + 로그저장 메소드 호출
        private void ShowMessage(string clickedBtn, string showMessage)
        {
            string activeMessage = "[" + DateTime.Now.ToString() + "]  [ 대여/반납 관리 ]" +
                                   "  <" + clickedBtn + ">  " + showMessage;
            MessageBox.Show(showMessage);
            listBox1.Items.Insert(0, activeMessage);
            WriteLog(activeMessage);
        }
    }
}
