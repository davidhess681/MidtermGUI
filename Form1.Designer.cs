namespace MidtermGUI
{
    partial class Form1
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
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lstLibrary = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(12, 12);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(75, 23);
            this.btnListAll.TabIndex = 0;
            this.btnListAll.Text = "List All Books";
            this.btnListAll.UseVisualStyleBackColor = true;
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.Location = new System.Drawing.Point(12, 140);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(134, 23);
            this.btnSearchTitle.TabIndex = 1;
            this.btnSearchTitle.Text = "Search by Title";
            this.btnSearchTitle.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(12, 169);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(148, 23);
            this.btnSearchAuthor.TabIndex = 4;
            this.btnSearchAuthor.Text = "Search by Author";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(301, 230);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(398, 230);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(488, 230);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(218, 283);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(132, 23);
            this.btnSaveClose.TabIndex = 8;
            this.btnSaveClose.Text = "Save and Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter search term here:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(39, 258);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lstLibrary
            // 
            this.lstLibrary.FormattingEnabled = true;
            this.lstLibrary.Location = new System.Drawing.Point(301, 12);
            this.lstLibrary.Name = "lstLibrary";
            this.lstLibrary.Size = new System.Drawing.Size(262, 212);
            this.lstLibrary.TabIndex = 2;
            this.lstLibrary.SelectedIndexChanged += new System.EventHandler(this.lstLibrary_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstLibrary);
            this.Controls.Add(this.btnSearchTitle);
            this.Controls.Add(this.btnListAll);
            this.Name = "Form1";
            this.Text = "Grand Circus Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnSearchTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox lstLibrary;
    }
}

