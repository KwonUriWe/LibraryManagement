namespace LibraryManagement
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_allOverdueCnt = new System.Windows.Forms.Label();
            this.label_allBrwdCnt = new System.Windows.Forms.Label();
            this.label_allUserCnt = new System.Windows.Forms.Label();
            this.label_allBookCnt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_userId = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Borrow = new System.Windows.Forms.Button();
            this.label_bookName = new System.Windows.Forms.Label();
            this.label_isbn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_book = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_sUser = new System.Windows.Forms.Button();
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_book = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_sBook = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도서관리ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2162, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도서관리ToolStripMenuItem
            // 
            this.도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
            this.도서관리ToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.도서관리ToolStripMenuItem.Text = "도서 관리";
            this.도서관리ToolStripMenuItem.Click += new System.EventHandler(this.도서관리ToolStripMenuItem_Click);
            // 
            // 사용자관리ToolStripMenuItem
            // 
            this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
            this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(163, 36);
            this.사용자관리ToolStripMenuItem.Text = "사용자 관리";
            this.사용자관리ToolStripMenuItem.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_allOverdueCnt);
            this.groupBox1.Controls.Add(this.label_allBrwdCnt);
            this.groupBox1.Controls.Add(this.label_allUserCnt);
            this.groupBox1.Controls.Add(this.label_allBookCnt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(789, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(225, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서 현황";
            // 
            // label_allOverdueCnt
            // 
            this.label_allOverdueCnt.AutoSize = true;
            this.label_allOverdueCnt.Location = new System.Drawing.Point(143, 168);
            this.label_allOverdueCnt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_allOverdueCnt.Name = "label_allOverdueCnt";
            this.label_allOverdueCnt.Size = new System.Drawing.Size(56, 24);
            this.label_allOverdueCnt.TabIndex = 7;
            this.label_allOverdueCnt.Text = "label";
            // 
            // label_allBrwdCnt
            // 
            this.label_allBrwdCnt.AutoSize = true;
            this.label_allBrwdCnt.Location = new System.Drawing.Point(143, 126);
            this.label_allBrwdCnt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_allBrwdCnt.Name = "label_allBrwdCnt";
            this.label_allBrwdCnt.Size = new System.Drawing.Size(56, 24);
            this.label_allBrwdCnt.TabIndex = 6;
            this.label_allBrwdCnt.Text = "label";
            // 
            // label_allUserCnt
            // 
            this.label_allUserCnt.AutoSize = true;
            this.label_allUserCnt.Location = new System.Drawing.Point(143, 84);
            this.label_allUserCnt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_allUserCnt.Name = "label_allUserCnt";
            this.label_allUserCnt.Size = new System.Drawing.Size(56, 24);
            this.label_allUserCnt.TabIndex = 5;
            this.label_allUserCnt.Text = "label";
            // 
            // label_allBookCnt
            // 
            this.label_allBookCnt.AutoSize = true;
            this.label_allBookCnt.Location = new System.Drawing.Point(143, 42);
            this.label_allBookCnt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_allBookCnt.Name = "label_allBookCnt";
            this.label_allBookCnt.Size = new System.Drawing.Size(56, 24);
            this.label_allBookCnt.TabIndex = 4;
            this.label_allBookCnt.Text = "label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "연체 도서 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "대출 도서 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "사용자 수 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "전체 도서 : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_userId);
            this.groupBox2.Controls.Add(this.button_Return);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button_Borrow);
            this.groupBox2.Controls.Add(this.label_bookName);
            this.groupBox2.Controls.Add(this.label_isbn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(33, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(745, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여 / 반납";
            // 
            // label_userId
            // 
            this.label_userId.AutoSize = true;
            this.label_userId.Location = new System.Drawing.Point(152, 160);
            this.label_userId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_userId.Name = "label_userId";
            this.label_userId.Size = new System.Drawing.Size(56, 24);
            this.label_userId.TabIndex = 10;
            this.label_userId.Text = "label";
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(570, 120);
            this.button_Return.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(162, 72);
            this.button_Return.TabIndex = 7;
            this.button_Return.Text = "반납";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Isbn  :";
            // 
            // button_Borrow
            // 
            this.button_Borrow.Location = new System.Drawing.Point(570, 38);
            this.button_Borrow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(162, 72);
            this.button_Borrow.TabIndex = 6;
            this.button_Borrow.Text = "대여";
            this.button_Borrow.UseVisualStyleBackColor = true;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // label_bookName
            // 
            this.label_bookName.AutoSize = true;
            this.label_bookName.Location = new System.Drawing.Point(152, 108);
            this.label_bookName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_bookName.Name = "label_bookName";
            this.label_bookName.Size = new System.Drawing.Size(56, 24);
            this.label_bookName.TabIndex = 9;
            this.label_bookName.Text = "label";
            // 
            // label_isbn
            // 
            this.label_isbn.AutoSize = true;
            this.label_isbn.Location = new System.Drawing.Point(152, 56);
            this.label_isbn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_isbn.Name = "label_isbn";
            this.label_isbn.Size = new System.Drawing.Size(56, 24);
            this.label_isbn.TabIndex = 8;
            this.label_isbn.Text = "label";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "사용자 ID  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "도서 제목  :";
            // 
            // textBox_book
            // 
            this.textBox_book.Location = new System.Drawing.Point(1027, 38);
            this.textBox_book.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_book.Name = "textBox_book";
            this.textBox_book.Size = new System.Drawing.Size(414, 35);
            this.textBox_book.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_sUser);
            this.groupBox4.Controls.Add(this.dataGridView_user);
            this.groupBox4.Controls.Add(this.textBox_user);
            this.groupBox4.Location = new System.Drawing.Point(1660, 286);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(483, 924);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "사용자 현황";
            // 
            // button_sUser
            // 
            this.button_sUser.Location = new System.Drawing.Point(306, 36);
            this.button_sUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_sUser.Name = "button_sUser";
            this.button_sUser.Size = new System.Drawing.Size(162, 42);
            this.button_sUser.TabIndex = 11;
            this.button_sUser.Text = "사용자 검색";
            this.button_sUser.UseVisualStyleBackColor = true;
            this.button_sUser.Click += new System.EventHandler(this.button_sUser_Click);
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.AllowUserToAddRows = false;
            this.dataGridView_user.AllowUserToDeleteRows = false;
            this.dataGridView_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Location = new System.Drawing.Point(13, 92);
            this.dataGridView_user.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.ReadOnly = true;
            this.dataGridView_user.RowHeadersWidth = 82;
            this.dataGridView_user.RowTemplate.Height = 23;
            this.dataGridView_user.Size = new System.Drawing.Size(455, 820);
            this.dataGridView_user.TabIndex = 0;
            this.dataGridView_user.CurrentCellChanged += new System.EventHandler(this.DataGridView_user_CurrentCellChanged);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(13, 38);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(281, 35);
            this.textBox_user.TabIndex = 10;
            // 
            // dataGridView_book
            // 
            this.dataGridView_book.AllowUserToAddRows = false;
            this.dataGridView_book.AllowUserToDeleteRows = false;
            this.dataGridView_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book.Location = new System.Drawing.Point(11, 92);
            this.dataGridView_book.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView_book.Name = "dataGridView_book";
            this.dataGridView_book.ReadOnly = true;
            this.dataGridView_book.RowHeadersWidth = 82;
            this.dataGridView_book.RowTemplate.Height = 23;
            this.dataGridView_book.Size = new System.Drawing.Size(1605, 820);
            this.dataGridView_book.TabIndex = 0;
            this.dataGridView_book.CurrentCellChanged += new System.EventHandler(this.DataGridView_book_CurrentCellChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_sBook);
            this.groupBox3.Controls.Add(this.dataGridView_book);
            this.groupBox3.Controls.Add(this.textBox_book);
            this.groupBox3.Location = new System.Drawing.Point(22, 286);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(1627, 924);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서 현황";
            // 
            // button_sBook
            // 
            this.button_sBook.Location = new System.Drawing.Point(1454, 36);
            this.button_sBook.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_sBook.Name = "button_sBook";
            this.button_sBook.Size = new System.Drawing.Size(162, 42);
            this.button_sBook.TabIndex = 9;
            this.button_sBook.Text = "도서 검색";
            this.button_sBook.UseVisualStyleBackColor = true;
            this.button_sBook.Click += new System.EventHandler(this.button_sBook_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(1023, 74);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1102, 196);
            this.listBox1.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2162, 1230);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_allOverdueCnt;
        private System.Windows.Forms.Label label_allBrwdCnt;
        private System.Windows.Forms.Label label_allUserCnt;
        private System.Windows.Forms.Label label_allBookCnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_book;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_Borrow;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_user;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBorrowedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_sUser;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Button button_sBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_userId;
        private System.Windows.Forms.Label label_bookName;
        private System.Windows.Forms.Label label_isbn;
    }
}

