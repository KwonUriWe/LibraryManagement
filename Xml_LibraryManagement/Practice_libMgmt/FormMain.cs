using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Text = "도서관 관리_Xml";

            //전체 도서 수
            label_allBookCnt.Text = DateManager.Books.Count.ToString();

            //사용자 수
            label_allUserCnt.Text = DateManager.Users.Count.ToString();

            //대출 중인 도서 수
            label_allBrwdCnt.Text = DateManager.Books.Where((x) => x.isBorrowed).Count().ToString();

            //연체 중인 도서 수
            label_allOverdueCnt.Text = DateManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) > DateTime.Now;
            }).Count().ToString();

            //데이터 그리드 설정
            dataGridView_book.DataSource = DateManager.Books;
            dataGridView_user.DataSource = DateManager.Users;
            dataGridView_book.CurrentCellChanged += DataGridView_book_CurrentCellChanged;
            dataGridView_user.CurrentCellChanged += DataGridView_user_CurrentCellChanged;

        }

        //DataGridView_user이 바뀌었을때 발생하는 이벤트
        private void DataGridView_user_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                User user = dataGridView_user.CurrentRow.DataBoundItem as User;
                textBox_userID.Text = user.Id.ToString();
            }
            catch (Exception)
            {

            }
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

        //DataGridView_book이 바뀌었을때 발생하는 이벤트
        private void DataGridView_book_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Book book = dataGridView_book.CurrentRow.DataBoundItem as Book;
                textBox_Isbn.Text = book.Isbn;
                textBox_bookName.Text = book.Name;
            }
            catch (Exception)
            {

            }
        }

        //대여 버튼 클릭
        private void button_Borrow_Click(object sender, EventArgs e)
        {
            if (textBox_Isbn.Text.Trim() == "" || textBox_bookName.Text.Trim() == "" || textBox_userID.Text.Trim() == "")
            {
                ShowMessage(button_Borrow.Text, "Isbn 입력.");
            }
            else
            {
                try
                {
                    Book book = DateManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
                    if (book.isBorrowed)    //대여 여부 확인
                    {
                        ShowMessage(button_Borrow.Text, "대여 중인 도서.");
                    }
                    else
                    {
                        User user = DateManager.Users.Single((x) => x.Id.ToString() == textBox_userID.Text);
                        book.UserId = user.Id;              //book 대여자 정보에 사용자 정보를 대입
                        book.UserName = user.Name;
                        book.isBorrowed = true;             //대여했으니 대여여부 참으로 변경
                        book.BorrowedAt = DateTime.Now;     //대여 날짜는 지금

                        dataGridView_book.DataSource = null;    //기존 정보를 지움
                        dataGridView_book.DataSource = DateManager.Books;   //새로 생성한 정보를 소스에 넣어줌
                        DateManager.BookSave(); //저장

                        ShowMessage(button_Borrow.Text, "\"" + user.Name + "\"님. \"" + book.Name + "\" 대여 완료.");
                    }
                }
                catch (Exception)
                {
                    ShowMessage(button_Borrow.Text, "존재하지 않는 도서 또는 사용자.");
                }
            }
        }

        //반납 버튼 클릭
        private void button_Return_Click(object sender, EventArgs e)
        {
            if(textBox_Isbn.Text.Trim() == "" || textBox_bookName.Text.Trim() == "" || textBox_userID.Text.Trim() == "")
            {
                MessageBox.Show("모든 정보 입력 필요.");
            }
            else
            {
                try
                {
                    Book book = DateManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
                    if (book.isBorrowed)    //대여 여부 확인
                    {
                        DateTime oldDay = book.BorrowedAt;  //대여날짜를 따로 저장
                        string UserName = book.UserName;    //대여자 이름 따로 저장
                        book.UserId = 0;              //book 대여자 정보 비움
                        book.UserName = "";
                        book.isBorrowed = false;             //반납했으니 대여여부 거짓으로 변경
                        book.BorrowedAt = new DateTime();     //대여 날짜 정보 비움 //따로 저장해 둔 대여날짜는 유지됨

                        dataGridView_book.DataSource = null;    //기존 정보를 지움
                        dataGridView_book.DataSource = DateManager.Books;   //새로 생성한 정보를 소스에 넣어줌
                        DateManager.BookSave(); //저장

                        TimeSpan timeDiff = DateTime.Now - oldDay;  //오늘 날짜와 대여 날짜의 차를 구함
                        int diffDays = timeDiff.Days;   //날짜의 차를 int형으로 변환

                        if (diffDays > 7) //7일 초과로 연체됨
                        {
                            ShowMessage(button_Return.Text, "\"" + UserName + "\"님. \"" + book.Name + "\" 반납 완료. (연체)");
                        }
                        else
                        {
                            ShowMessage(button_Return.Text, "\"" + UserName + "\"님. \"" + book.Name + "\" 반납 완료.");
                        }
                    }
                    else
                    {
                        ShowMessage(button_Return.Text, "대여 중인 도서가 아님.");
                    }
                }
                catch (Exception)
                {
                    ShowMessage(button_Return.Text, "존재하지 않는 도서/사용자.");
                }
            }
        }

        //도서관리 메뉴 클릭
        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormBook().ShowDialog();
            DateManager.BookLoad();    //FormBook 열어 수정한 내용을 폼1에 불러옴
            DateManager.UserLoad();
            dataGridView_book.DataSource = null;
            dataGridView_book.DataSource = DateManager.Books;
        }

        //사용자관리 메뉴 클릭
        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUser().ShowDialog();
            DateManager.BookLoad();    //FormUser 열어 수정한 내용을 폼1에 불러옴
            DateManager.UserLoad();
            dataGridView_book.DataSource = null;
            dataGridView_book.DataSource = DateManager.Books;
        }

        //재입력 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Isbn.Text = "";
            textBox_userID.Text = "";
            textBox_bookName.Text = "";
        }
    }
}
