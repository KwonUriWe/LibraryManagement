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
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
            Text = "도서 관리";

            dataGridView_booklist.DataSource = DateManager.Books;
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

        //DataGridView가 바뀌었을때 발생하는 이벤트
        private void dataGridView_booklist_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Book book = dataGridView_booklist.CurrentRow.DataBoundItem as Book;
                textBox_isbn.Text = book.Isbn;
                textBox_bookName.Text = book.Name;
                textBox_publisher.Text = book.Publisher;
                textBox_page.Text = book.Page.ToString();
            }
            catch (Exception)
            {

            }
        }

        //추가 버튼 클릭
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(DateManager.Books.Exists((x)=>x.Isbn == textBox_isbn.Text))  //Isbn 기 등록 여부 확인
                {
                    ShowMessage(button_add.Text, "기 등록 된 도서.");
                }
                else
                {
                    Book book = new Book()           //각 요소들의 값 대입
                    {
                        Isbn = textBox_isbn.Text,
                        Name = textBox_bookName.Text,
                        Publisher = textBox_publisher.Text,
                        Page = int.Parse(textBox_page.Text)
                    };
                    DateManager.Books.Add(book);    //대입한 값 리스트에 추가
                    
                    ShowMessage(button_add.Text, textBox_isbn.Text + " 도서 정보 추가 완료.");

                    dataGridView_booklist.DataSource = null;
                    dataGridView_booklist.DataSource = DateManager.Books;   //새로 생성한 정보를 소스에 넣어줌
                    DateManager.BookSave(); //저장

                }
            }
            catch(Exception)
            {

            }
        }

        //수정 버튼 클릭
        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = DateManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);   //입력값과 같은값의 Isbs을 가진 요소 반환
                book.Name = textBox_bookName.Text;           //각 요소들의 값 대입
                book.Publisher = textBox_publisher.Text;
                book.Page = int.Parse(textBox_page.Text);

                ShowMessage(button_modify.Text, textBox_isbn.Text + " 도서 정보 수정 완료.");
                
                dataGridView_booklist.DataSource = null;
                dataGridView_booklist.DataSource = DateManager.Books;   //새로 생성한 정보를 소스에 넣어줌
                DateManager.BookSave(); //저장

            }
            catch (Exception)
            {
                ShowMessage(button_modify.Text, "존재하지 않는 도서. Isbn값 수정 불가.");
            }
           
        }

        //삭제 버튼 클릭
        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = DateManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);   //입력값과 같은값의 Isbs을 가진 요소 반환
             
                ShowMessage(button_delete.Text, textBox_isbn.Text + " 도서 정보 삭제 완료.");
                DateManager.Books.Remove(book); //반환된 개체 삭제

                dataGridView_booklist.DataSource = null;
                dataGridView_booklist.DataSource = DateManager.Books;   //새로 생성한 정보를 소스에 넣어줌
                DateManager.BookSave(); //저장
                
            }
            catch (Exception)
            {
                ShowMessage(button_delete.Text, "존재하지 않는 도서.");
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
    }
}
