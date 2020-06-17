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
            this.menuStrip1.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도서관리ToolStripMenuItem
            // 
            this.도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
            this.도서관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.도서관리ToolStripMenuItem.Text = "도서 관리";
            this.도서관리ToolStripMenuItem.Click += new System.EventHandler(this.도서관리ToolStripMenuItem_Click);
            // 
            // 사용자관리ToolStripMenuItem
            // 
            this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
            this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(425, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서 현황";
            // 
            // label_allOverdueCnt
            // 
            this.label_allOverdueCnt.AutoSize = true;
            this.label_allOverdueCnt.Location = new System.Drawing.Point(77, 84);
            this.label_allOverdueCnt.Name = "label_allOverdueCnt";
            this.label_allOverdueCnt.Size = new System.Drawing.Size(32, 12);
            this.label_allOverdueCnt.TabIndex = 7;
            this.label_allOverdueCnt.Text = "label";
            // 
            // label_allBrwdCnt
            // 
            this.label_allBrwdCnt.AutoSize = true;
            this.label_allBrwdCnt.Location = new System.Drawing.Point(77, 63);
            this.label_allBrwdCnt.Name = "label_allBrwdCnt";
            this.label_allBrwdCnt.Size = new System.Drawing.Size(32, 12);
            this.label_allBrwdCnt.TabIndex = 6;
            this.label_allBrwdCnt.Text = "label";
            // 
            // label_allUserCnt
            // 
            this.label_allUserCnt.AutoSize = true;
            this.label_allUserCnt.Location = new System.Drawing.Point(77, 42);
            this.label_allUserCnt.Name = "label_allUserCnt";
            this.label_allUserCnt.Size = new System.Drawing.Size(32, 12);
            this.label_allUserCnt.TabIndex = 5;
            this.label_allUserCnt.Text = "label";
            // 
            // label_allBookCnt
            // 
            this.label_allBookCnt.AutoSize = true;
            this.label_allBookCnt.Location = new System.Drawing.Point(77, 21);
            this.label_allBookCnt.Name = "label_allBookCnt";
            this.label_allBookCnt.Size = new System.Drawing.Size(32, 12);
            this.label_allBookCnt.TabIndex = 4;
            this.label_allBookCnt.Text = "label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "연체 도서 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "대출 도서 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "사용자 수 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
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
            this.groupBox2.Location = new System.Drawing.Point(18, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여 / 반납";
            // 
            // label_userId
            // 
            this.label_userId.AutoSize = true;
            this.label_userId.Location = new System.Drawing.Point(78, 80);
            this.label_userId.Name = "label_userId";
            this.label_userId.Size = new System.Drawing.Size(32, 12);
            this.label_userId.TabIndex = 10;
            this.label_userId.Text = "label";
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(307, 60);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(87, 36);
            this.button_Return.TabIndex = 7;
            this.button_Return.Text = "반납";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Isbn  :";
            // 
            // button_Borrow
            // 
            this.button_Borrow.Location = new System.Drawing.Point(307, 19);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(87, 36);
            this.button_Borrow.TabIndex = 6;
            this.button_Borrow.Text = "대여";
            this.button_Borrow.UseVisualStyleBackColor = true;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // label_bookName
            // 
            this.label_bookName.AutoSize = true;
            this.label_bookName.Location = new System.Drawing.Point(78, 54);
            this.label_bookName.Name = "label_bookName";
            this.label_bookName.Size = new System.Drawing.Size(32, 12);
            this.label_bookName.TabIndex = 9;
            this.label_bookName.Text = "label";
            // 
            // label_isbn
            // 
            this.label_isbn.AutoSize = true;
            this.label_isbn.Location = new System.Drawing.Point(78, 28);
            this.label_isbn.Name = "label_isbn";
            this.label_isbn.Size = new System.Drawing.Size(32, 12);
            this.label_isbn.TabIndex = 8;
            this.label_isbn.Text = "label";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "사용자 ID  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "도서 이름  :";
            // 
            // textBox_book
            // 
            this.textBox_book.Location = new System.Drawing.Point(553, 19);
            this.textBox_book.Name = "textBox_book";
            this.textBox_book.Size = new System.Drawing.Size(225, 21);
            this.textBox_book.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_sUser);
            this.groupBox4.Controls.Add(this.dataGridView_user);
            this.groupBox4.Controls.Add(this.textBox_user);
            this.groupBox4.Location = new System.Drawing.Point(894, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 462);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "사용자 현황";
            // 
            // button_sUser
            // 
            this.button_sUser.Location = new System.Drawing.Point(165, 18);
            this.button_sUser.Name = "button_sUser";
            this.button_sUser.Size = new System.Drawing.Size(87, 21);
            this.button_sUser.TabIndex = 11;
            this.button_sUser.Text = "검색";
            this.button_sUser.UseVisualStyleBackColor = true;
            this.button_sUser.Click += new System.EventHandler(this.button_sUser_Click);
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.AllowUserToAddRows = false;
            this.dataGridView_user.AllowUserToDeleteRows = false;
            this.dataGridView_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Location = new System.Drawing.Point(7, 46);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.ReadOnly = true;
            this.dataGridView_user.RowHeadersWidth = 82;
            this.dataGridView_user.RowTemplate.Height = 23;
            this.dataGridView_user.Size = new System.Drawing.Size(245, 410);
            this.dataGridView_user.TabIndex = 0;
            this.dataGridView_user.CurrentCellChanged += new System.EventHandler(this.DataGridView_user_CurrentCellChanged);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(7, 19);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(153, 21);
            this.textBox_user.TabIndex = 10;
            // 
            // dataGridView_book
            // 
            this.dataGridView_book.AllowUserToAddRows = false;
            this.dataGridView_book.AllowUserToDeleteRows = false;
            this.dataGridView_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book.Location = new System.Drawing.Point(6, 46);
            this.dataGridView_book.Name = "dataGridView_book";
            this.dataGridView_book.ReadOnly = true;
            this.dataGridView_book.RowHeadersWidth = 82;
            this.dataGridView_book.RowTemplate.Height = 23;
            this.dataGridView_book.Size = new System.Drawing.Size(864, 410);
            this.dataGridView_book.TabIndex = 0;
            this.dataGridView_book.CurrentCellChanged += new System.EventHandler(this.DataGridView_book_CurrentCellChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_sBook);
            this.groupBox3.Controls.Add(this.dataGridView_book);
            this.groupBox3.Controls.Add(this.textBox_book);
            this.groupBox3.Location = new System.Drawing.Point(12, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 462);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서 현황";
            // 
            // button_sBook
            // 
            this.button_sBook.Location = new System.Drawing.Point(783, 18);
            this.button_sBook.Name = "button_sBook";
            this.button_sBook.Size = new System.Drawing.Size(87, 21);
            this.button_sBook.TabIndex = 9;
            this.button_sBook.Text = "검색";
            this.button_sBook.UseVisualStyleBackColor = true;
            this.button_sBook.Click += new System.EventHandler(this.button_sBook_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(551, 37);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(595, 100);
            this.listBox1.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 615);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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

