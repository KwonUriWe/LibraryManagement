namespace LibraryManagement
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_sUser = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_userlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userlist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_reset);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.button_modify);
            this.groupBox2.Controls.Add(this.textBox_name);
            this.groupBox2.Controls.Add(this.textBox_id);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(709, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사용자 추가 / 수정 / 삭제";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(362, 36);
            this.button_reset.Margin = new System.Windows.Forms.Padding(6);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(162, 46);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "재입력";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(535, 36);
            this.button_add.Margin = new System.Windows.Forms.Padding(6);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(162, 46);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(535, 92);
            this.button_delete.Margin = new System.Windows.Forms.Padding(6);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(162, 46);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(362, 92);
            this.button_modify.Margin = new System.Windows.Forms.Padding(6);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(162, 46);
            this.button_modify.TabIndex = 5;
            this.button_modify.Text = "수정";
            this.button_modify.UseVisualStyleBackColor = true;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(142, 98);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(209, 35);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(142, 42);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(209, 35);
            this.textBox_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 ID";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(15, 241);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(704, 700);
            this.listBox1.TabIndex = 2;
            // 
            // button_sUser
            // 
            this.button_sUser.Location = new System.Drawing.Point(550, 187);
            this.button_sUser.Margin = new System.Windows.Forms.Padding(6);
            this.button_sUser.Name = "button_sUser";
            this.button_sUser.Size = new System.Drawing.Size(162, 42);
            this.button_sUser.TabIndex = 13;
            this.button_sUser.Text = "사용자 검색";
            this.button_sUser.UseVisualStyleBackColor = true;
            this.button_sUser.Click += new System.EventHandler(this.button_sUser_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(157, 193);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(382, 35);
            this.textBox_user.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "이름 / ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_userlist);
            this.groupBox1.Location = new System.Drawing.Point(736, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(493, 932);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView_userlist
            // 
            this.dataGridView_userlist.AllowUserToAddRows = false;
            this.dataGridView_userlist.AllowUserToDeleteRows = false;
            this.dataGridView_userlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_userlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_userlist.Location = new System.Drawing.Point(11, 27);
            this.dataGridView_userlist.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_userlist.Name = "dataGridView_userlist";
            this.dataGridView_userlist.ReadOnly = true;
            this.dataGridView_userlist.RowHeadersWidth = 82;
            this.dataGridView_userlist.RowTemplate.Height = 23;
            this.dataGridView_userlist.Size = new System.Drawing.Size(470, 893);
            this.dataGridView_userlist.TabIndex = 0;
            this.dataGridView_userlist.CurrentCellChanged += new System.EventHandler(this.DataGridView_userlist_CurrentCellChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 972);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_sUser);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormUser";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_userlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_sUser;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_userlist;
    }
}