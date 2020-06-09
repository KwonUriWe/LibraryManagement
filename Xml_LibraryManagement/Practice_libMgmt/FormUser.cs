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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            Text = "사용자 관리";

            dataGridView_user.DataSource = DateManager.Users;
            dataGridView_user.CurrentCellChanged += DataGridView_user_CurrentCellChanged;

            //사용자 추가
            button_add.Click += (sender, e) =>
            {
                try
                {
                    if (DateManager.Users.Exists((x) => x.Id == int.Parse(textBox_id.Text)))
                    {
                        ShowMessage(button_add.Text, "중복된 ID.");
                    }
                    else
                    {
                        User user = new User()           //각 요소들의 값 대입
                        {
                            Id = int.Parse(textBox_id.Text),
                            Name = textBox_name.Text
                        };
                        DateManager.Users.Add(user);    //대입한 값 리스트에 추가
                        
                        ShowMessage(button_add.Text, textBox_id.Text + " 사용자 정보 추가 완료.");

                        dataGridView_user.DataSource = null;
                        dataGridView_user.DataSource = DateManager.Users;   //새로 생성한 정보를 소스에 넣어줌
                        DateManager.UserSave(); //저장

                    }
                }
                catch (Exception)
                {

                }
            };

            //사용자 수정
            button_modify.Click += (sender, e) =>
            {
                try
                {
                    User user = DateManager.Users.Single((x) => x.Id == int.Parse(textBox_id.Text));   //입력값과 같은값의 Id를 가진 요소 반환
                    user.Name = textBox_name.Text;           //각 요소들의 값 대입

                    try
                    {
                        Book book = DateManager.Books.Single((x) => x.UserId == int.Parse(textBox_id.Text));
                        book.UserName = textBox_name.Text;    //이름바꾼 사용자가 대여 중인 책의 대여자 이름 변경
                    }
                    catch (Exception)
                    {

                    }
                    
                    ShowMessage(button_modify.Text, textBox_id.Text + " 사용자 정보 수정 완료.");

                    dataGridView_user.DataSource = null;
                    dataGridView_user.DataSource = DateManager.Users;   //새로 생성한 정보를 소스에 넣어줌
                    DateManager.UserSave(); //저장
                }
                catch (Exception)
                {
                    ShowMessage(button_modify.Text, "존재하지 않는 사용자. Id값 수정 불가.");
                }
            };

            //사용자 삭제
            button_delete.Click += (sender, e) =>
            {
                try
                {
                    User user = DateManager.Users.Single((x) => x.Id == int.Parse(textBox_id.Text));   //입력값과 같은값의 Id를 가진 요소 반환
                    
                    ShowMessage(button_delete.Text, textBox_id.Text + " 사용자 정보 삭제 완료.");
                    DateManager.Users.Remove(user); //반환된 개체 삭제

                    dataGridView_user.DataSource = null;
                    dataGridView_user.DataSource = DateManager.Users;   //새로 생성한 정보를 소스에 넣어줌
                    DateManager.UserSave(); //저장
                }
                catch (Exception)
                {
                    ShowMessage(button_delete.Text, "존재하지 않는 사용자.");
                }
            };
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
            string activeMessage = "[" + DateTime.Now.ToString() + "]  [ 사용자 관리 ]" +
                                   "  <" + clickedBtn + ">  " + showMessage;
            MessageBox.Show(showMessage);
            listBox1.Items.Insert(0, activeMessage);
            WriteLog(activeMessage);
        }

        //DataGridView가 바뀌었을때 발생하는 이벤트
        private void DataGridView_user_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                User user = dataGridView_user.CurrentRow.DataBoundItem as User;
                textBox_id.Text = user.Id.ToString();
                textBox_name.Text = user.Name;
            }
            catch (Exception)
            {

            }
        }

        //재입력 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_name.Text = "";
        }

        private void button_modify_Click(object sender, EventArgs e)
        {

        }
    }
}
