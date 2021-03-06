﻿namespace Geosoft_Book_Management_System
{
    partial class bookMD
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
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.txt_book = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_publisher = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_owner = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modify = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_cate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(196, 265);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 9;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(26, 265);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 8;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // txt_book
            // 
            this.txt_book.Location = new System.Drawing.Point(101, 12);
            this.txt_book.Name = "txt_book";
            this.txt_book.Size = new System.Drawing.Size(165, 21);
            this.txt_book.TabIndex = 0;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(101, 48);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(121, 21);
            this.txt_author.TabIndex = 1;
            // 
            // txt_publisher
            // 
            this.txt_publisher.Location = new System.Drawing.Point(101, 84);
            this.txt_publisher.Name = "txt_publisher";
            this.txt_publisher.Size = new System.Drawing.Size(121, 21);
            this.txt_publisher.TabIndex = 2;
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(101, 120);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(121, 21);
            this.txt_year.TabIndex = 3;
            // 
            // txt_owner
            // 
            this.txt_owner.Location = new System.Drawing.Point(101, 192);
            this.txt_owner.Name = "txt_owner";
            this.txt_owner.Size = new System.Drawing.Size(121, 21);
            this.txt_owner.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "状态：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "所属：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "出版年：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "出版社：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "分类：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "作者：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "书名：";
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(111, 265);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(75, 23);
            this.modify.TabIndex = 7;
            this.modify.Text = "修改";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(101, 228);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 20);
            this.cb_status.TabIndex = 6;
            // 
            // cb_cate
            // 
            this.cb_cate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cate.FormattingEnabled = true;
            this.cb_cate.Location = new System.Drawing.Point(101, 156);
            this.cb_cate.Name = "cb_cate";
            this.cb_cate.Size = new System.Drawing.Size(121, 20);
            this.cb_cate.TabIndex = 4;
            // 
            // bookMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.cb_cate);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.txt_book);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_publisher);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_owner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "bookMD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "书目删修";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox txt_book;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_publisher;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_owner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_cate;
    }
}