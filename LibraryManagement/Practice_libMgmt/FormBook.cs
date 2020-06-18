using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormBook : Form
    {
        public SqlConnection conn = new SqlConnection();

        public FormBook()
        {
            InitializeComponent();
            Text = "도서 관리";

            viewAllBooks();

            //도서정보 추가
            button_add.Click += (sender, e) =>
            {
                string isbn = textBox_isbn.Text;
                string bookName = textBox_bookName.Text;
                string publisher = textBox_publisher.Text;
                string page = textBox_page.Text;

                if (textBox_isbn.Text.Trim() == "" || textBox_bookName.Text.Trim() == ""
                 || textBox_publisher.Text.Trim() == "" || textBox_page.Text.Trim() == "")
                {
                    ShowMessage(button_add.Text, "모든 정보 입력 필요.");
                }
                else
                {
                    ShowMessage(button_add.Text, QueryBook.Query_add(isbn, bookName, publisher, page));
                    viewAllBooks();
                }
            };

            //도서정보 수정
            button_modify.Click += (sender, e) =>
            {
                string isbn = textBox_isbn.Text;
                string bookName = textBox_bookName.Text;
                string publisher = textBox_publisher.Text;
                string page = textBox_page.Text;

                if (textBox_isbn.Text.Trim() == "" || textBox_bookName.Text.Trim() == ""
                    || textBox_publisher.Text.Trim() == "" || textBox_page.Text.Trim() == "")
                {
                    ShowMessage(button_add.Text, "모든 정보 입력 필요.");
                }
                else
                {
                    ShowMessage(button_modify.Text, QueryBook.Query_modify(isbn, bookName, publisher, page));
                    viewAllBooks();
                }
            };

            //도서정보 삭제
            button_delete.Click += (sender, e) =>
            {
                string isbn = textBox_isbn.Text;

                if (textBox_isbn.Text.Trim() == "" || textBox_bookName.Text.Trim() == ""
                    || textBox_publisher.Text.Trim() == "" || textBox_page.Text.Trim() == "")
                {
                    ShowMessage(button_add.Text, "모든 정보 입력 필요.");
                }
                else
                {
                    ShowMessage(button_delete.Text, QueryBook.Query_delete(isbn));
                    viewAllBooks();
                }
            };
        }

        //dataGridView_booklist 출력 메소드
        private void viewAllBooks()
        {
            ConnDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnDB.conn;
            cmd.CommandText = "Select * From Books order by isbn";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Books");

            dataGridView_booklist.DataSource = ds;
            dataGridView_booklist.DataMember = "Books";

            ConnDB.conn.Close();
            return;
        }

        //DataGridView가 바뀌었을때 발생하는 이벤트
        private void dataGridView_booklist_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var temp = dataGridView_booklist.CurrentRow;
                textBox_isbn.Text = dataGridView_booklist.CurrentRow.Cells[0].Value.ToString();
                textBox_bookName.Text = dataGridView_booklist.CurrentRow.Cells[1].Value.ToString();
                textBox_publisher.Text = dataGridView_booklist.CurrentRow.Cells[2].Value.ToString();
                textBox_page.Text = dataGridView_booklist.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        //재입력 버튼 클릭
        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_isbn.Text = "";
            textBox_bookName.Text = "";
            textBox_publisher.Text = "";
            textBox_page.Text = "";
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

                dataGridView_booklist.DataSource = ds;
                dataGridView_booklist.DataMember = "Books";

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

                dataGridView_booklist.DataSource = ds;
                dataGridView_booklist.DataMember = "Books";

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
            using (StreamWriter writer = new StreamWriter(@"./LogFile/Lib_Book.txt", true))
            {
                writer.WriteLine(contents);
            }
        }

        //메세지박스 팝업 + 로그저장 메소드 호출
        private void ShowMessage(string clickedBtn, string showMessage)
        {
            string activeMessage = "[" + DateTime.Now.ToString() + "]  [ 도서 관리 ]" +
                                   "  <" + clickedBtn + ">  " + showMessage;
            MessageBox.Show(showMessage);
            listBox1.Items.Insert(0, activeMessage);
            WriteLog(activeMessage);
        }
    }
}

