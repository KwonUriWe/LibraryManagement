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

            dataGridView_booklist.DataSource = ds;
            dataGridView_booklist.DataMember = "Books";

            ConnDB.conn.Close();
            return;
        }

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
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_isbn.Text = "";
            textBox_bookName.Text = "";
            textBox_publisher.Text = "";
            textBox_page.Text = "";
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
            string activeMessage = "[" + DateTime.Now.ToString() + "]  [ 도서 관리 ]" +
                                   "  <" + clickedBtn + ">  " + showMessage;
            MessageBox.Show(showMessage);
            listBox1.Items.Insert(0, activeMessage);
            WriteLog(activeMessage);
        }
    }
}
