using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            Text = "도서관 관리";

            viewAllUsers();
            viewAllBooks();

            //전체 도서 수
            label_allBookCnt.Text = QueryMain.Query_count("all");

            //사용자 수
            label_allUserCnt.Text = QueryMain.Query_count("user");

            //대출 중인 도서 수
            label_allBrwdCnt.Text = QueryMain.Query_count("brwd");

            //연체 중인 도서 수
            label_allOverdueCnt.Text = QueryMain.Query_count("ovrd");
        }

        //dataGridView_user 출력 메소드
        private void viewAllUsers()
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Users order by id desc";

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
            cmd.CommandText = "Select * From Books order by isbn";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Books");

            dataGridView_book.DataSource = ds;
            dataGridView_book.DataMember = "Books";

            ConnDB.conn.Close();
            return;
        }

        //대여 버튼 클릭시 발생하는 이벤트
        private void button_Borrow_Click(object sender, EventArgs e)
        {
            string userId = label_userId.Text;
            string isbn = label_isbn.Text;
            string bookName = label_bookName.Text;

            if (userId.Trim() == "" || isbn.Trim() == "" || bookName.Trim() == "")
            {
                ShowMessage(button_Borrow.Text, "모든 정보 입력 필요.");
            }
            else
            {
                ShowMessage(button_Borrow.Text, QueryMain.Query_Borrow(userId, isbn, bookName));
                viewAllBooks();
            }
        }

        //반납 버튼 클릭시 발생하는 이벤트
        private void button_Return_Click(object sender, EventArgs e)
        {
            string userId = label_userId.Text;
            string isbn = label_isbn.Text;
            string bookName = label_bookName.Text;

            if (userId.Trim() == "" || isbn.Trim() == "" || bookName.Trim() == "")
            {
                MessageBox.Show("모든 정보 입력 필요.");
            }
            else
            {
                ShowMessage(button_Return.Text, QueryMain.Query_Return(userId, isbn, bookName));
                viewAllBooks();
            }
        }

        //도서관리 메뉴 클릭시 발생하는 이벤트
        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBook form = new FormBook();
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            viewAllBooks();
        }

        //사용자관리 메뉴 클릭시 발생하는 이벤트
        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser form = new FormUser();
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.ShowDialog();
            viewAllUsers();
        }

        //DataGridView_user이 바뀌었을때 발생하는 이벤트
        private void DataGridView_user_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var temp = dataGridView_user.CurrentRow;
                label_userId.Text = dataGridView_user.CurrentRow.Cells[0].Value.ToString();
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
                label_isbn.Text = dataGridView_book.CurrentRow.Cells[0].Value.ToString();
                label_bookName.Text = dataGridView_book.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        //도서 검색 버튼 클릭시 발생하는 이벤트
        private void button_sBook_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            string sbook = "%" + textBox_book.Text + "%";
            bool canConvert = int.TryParse(textBox_book.Text, out n1);

            //입력값이 숫자로 변환되는지 확인. 숫자이면 id값, 아니면 name값
            if (canConvert == true)
            {
                ConnDB.ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConnDB.conn;
                cmd.CommandText = "Select * From Books where Isbn like @p1 order by Isbn";
                cmd.Parameters.AddWithValue("@p1", sbook);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Books");

                dataGridView_book.DataSource = ds;
                dataGridView_book.DataMember = "Books";

                ConnDB.conn.Close();
            }
            else
            {
                ConnDB.ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConnDB.conn;
                cmd.CommandText = "Select * From Books where Name like @p1 order by Isbn";
                cmd.Parameters.AddWithValue("@p1", sbook);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Books");

                dataGridView_book.DataSource = ds;
                dataGridView_book.DataMember = "Books";

                ConnDB.conn.Close();
            }

            return;
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
                cmd.CommandText = "Select * From Users where Id like @p1 order by Id";
                cmd.Parameters.AddWithValue("@p1", sUser);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Users");

                dataGridView_user.DataSource = ds;
                dataGridView_user.DataMember = "Users";

                ConnDB.conn.Close();
            }
            else
            {
                ConnDB.ConnectDB();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConnDB.conn;
                cmd.CommandText = "Select * From Users where Name like @p1 order by Id";
                cmd.Parameters.AddWithValue("@p1", sUser);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Users");

                dataGridView_user.DataSource = ds;
                dataGridView_user.DataMember = "Users";

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
            using (StreamWriter writer = new StreamWriter(@"./LogFile/Lib_main.txt", true))
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
