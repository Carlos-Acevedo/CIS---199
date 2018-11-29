namespace Program4
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
            this.addBook_GRB = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.title_LBL = new System.Windows.Forms.Label();
            this.author_LBL = new System.Windows.Forms.Label();
            this.publisher_LBL = new System.Windows.Forms.Label();
            this.copyright_LBL = new System.Windows.Forms.Label();
            this.callNumber_LBL = new System.Windows.Forms.Label();
            this.title_TXT = new System.Windows.Forms.TextBox();
            this.author_TXT = new System.Windows.Forms.TextBox();
            this.publisher_TXT = new System.Windows.Forms.TextBox();
            this.copyright_TXT = new System.Windows.Forms.TextBox();
            this.callNumber_TXT = new System.Windows.Forms.TextBox();
            this.addBook_BTN = new System.Windows.Forms.Button();
            this.yourBooks_GRB = new System.Windows.Forms.GroupBox();
            this.books_LBX = new System.Windows.Forms.ListBox();
            this.details_BTN = new System.Windows.Forms.Button();
            this.checkOut_BTN = new System.Windows.Forms.Button();
            this.return_BTN = new System.Windows.Forms.Button();
            this.addBook_GRB.SuspendLayout();
            this.yourBooks_GRB.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBook_GRB
            // 
            this.addBook_GRB.Controls.Add(this.addBook_BTN);
            this.addBook_GRB.Controls.Add(this.callNumber_TXT);
            this.addBook_GRB.Controls.Add(this.copyright_TXT);
            this.addBook_GRB.Controls.Add(this.publisher_TXT);
            this.addBook_GRB.Controls.Add(this.author_TXT);
            this.addBook_GRB.Controls.Add(this.title_TXT);
            this.addBook_GRB.Controls.Add(this.callNumber_LBL);
            this.addBook_GRB.Controls.Add(this.copyright_LBL);
            this.addBook_GRB.Controls.Add(this.publisher_LBL);
            this.addBook_GRB.Controls.Add(this.author_LBL);
            this.addBook_GRB.Controls.Add(this.title_LBL);
            this.addBook_GRB.Location = new System.Drawing.Point(12, 12);
            this.addBook_GRB.Name = "addBook_GRB";
            this.addBook_GRB.Size = new System.Drawing.Size(200, 186);
            this.addBook_GRB.TabIndex = 0;
            this.addBook_GRB.TabStop = false;
            this.addBook_GRB.Text = "Add Book";
            // 
            // title_LBL
            // 
            this.title_LBL.AutoSize = true;
            this.title_LBL.Location = new System.Drawing.Point(43, 16);
            this.title_LBL.Name = "title_LBL";
            this.title_LBL.Size = new System.Drawing.Size(30, 13);
            this.title_LBL.TabIndex = 0;
            this.title_LBL.Text = "Title:";
            // 
            // author_LBL
            // 
            this.author_LBL.AutoSize = true;
            this.author_LBL.Location = new System.Drawing.Point(32, 42);
            this.author_LBL.Name = "author_LBL";
            this.author_LBL.Size = new System.Drawing.Size(41, 13);
            this.author_LBL.TabIndex = 1;
            this.author_LBL.Text = "Author:";
            // 
            // publisher_LBL
            // 
            this.publisher_LBL.AutoSize = true;
            this.publisher_LBL.Location = new System.Drawing.Point(20, 68);
            this.publisher_LBL.Name = "publisher_LBL";
            this.publisher_LBL.Size = new System.Drawing.Size(53, 13);
            this.publisher_LBL.TabIndex = 2;
            this.publisher_LBL.Text = "Publisher:";
            // 
            // copyright_LBL
            // 
            this.copyright_LBL.AutoSize = true;
            this.copyright_LBL.Location = new System.Drawing.Point(19, 94);
            this.copyright_LBL.Name = "copyright_LBL";
            this.copyright_LBL.Size = new System.Drawing.Size(54, 13);
            this.copyright_LBL.TabIndex = 3;
            this.copyright_LBL.Text = "Copyright:";
            // 
            // callNumber_LBL
            // 
            this.callNumber_LBL.AutoSize = true;
            this.callNumber_LBL.Location = new System.Drawing.Point(6, 120);
            this.callNumber_LBL.Name = "callNumber_LBL";
            this.callNumber_LBL.Size = new System.Drawing.Size(67, 13);
            this.callNumber_LBL.TabIndex = 4;
            this.callNumber_LBL.Text = "Call Number:";
            // 
            // title_TXT
            // 
            this.title_TXT.Location = new System.Drawing.Point(79, 13);
            this.title_TXT.Name = "title_TXT";
            this.title_TXT.Size = new System.Drawing.Size(100, 20);
            this.title_TXT.TabIndex = 5;
            // 
            // author_TXT
            // 
            this.author_TXT.Location = new System.Drawing.Point(79, 39);
            this.author_TXT.Name = "author_TXT";
            this.author_TXT.Size = new System.Drawing.Size(100, 20);
            this.author_TXT.TabIndex = 6;
            // 
            // publisher_TXT
            // 
            this.publisher_TXT.Location = new System.Drawing.Point(79, 65);
            this.publisher_TXT.Name = "publisher_TXT";
            this.publisher_TXT.Size = new System.Drawing.Size(100, 20);
            this.publisher_TXT.TabIndex = 7;
            // 
            // copyright_TXT
            // 
            this.copyright_TXT.Location = new System.Drawing.Point(79, 91);
            this.copyright_TXT.Name = "copyright_TXT";
            this.copyright_TXT.Size = new System.Drawing.Size(100, 20);
            this.copyright_TXT.TabIndex = 8;
            // 
            // callNumber_TXT
            // 
            this.callNumber_TXT.Location = new System.Drawing.Point(79, 117);
            this.callNumber_TXT.Name = "callNumber_TXT";
            this.callNumber_TXT.Size = new System.Drawing.Size(100, 20);
            this.callNumber_TXT.TabIndex = 9;
            // 
            // addBook_BTN
            // 
            this.addBook_BTN.Location = new System.Drawing.Point(63, 143);
            this.addBook_BTN.Name = "addBook_BTN";
            this.addBook_BTN.Size = new System.Drawing.Size(75, 23);
            this.addBook_BTN.TabIndex = 10;
            this.addBook_BTN.Text = "Add Book";
            this.addBook_BTN.UseVisualStyleBackColor = true;
            this.addBook_BTN.Click += new System.EventHandler(this.addBook_BTN_Click);
            // 
            // yourBooks_GRB
            // 
            this.yourBooks_GRB.Controls.Add(this.return_BTN);
            this.yourBooks_GRB.Controls.Add(this.checkOut_BTN);
            this.yourBooks_GRB.Controls.Add(this.details_BTN);
            this.yourBooks_GRB.Controls.Add(this.books_LBX);
            this.yourBooks_GRB.Location = new System.Drawing.Point(240, 12);
            this.yourBooks_GRB.Name = "yourBooks_GRB";
            this.yourBooks_GRB.Size = new System.Drawing.Size(249, 183);
            this.yourBooks_GRB.TabIndex = 1;
            this.yourBooks_GRB.TabStop = false;
            this.yourBooks_GRB.Text = "Your Books";
            // 
            // books_LBX
            // 
            this.books_LBX.FormattingEnabled = true;
            this.books_LBX.Location = new System.Drawing.Point(6, 19);
            this.books_LBX.Name = "books_LBX";
            this.books_LBX.Size = new System.Drawing.Size(237, 121);
            this.books_LBX.TabIndex = 0;
            // 
            // details_BTN
            // 
            this.details_BTN.Location = new System.Drawing.Point(6, 143);
            this.details_BTN.Name = "details_BTN";
            this.details_BTN.Size = new System.Drawing.Size(75, 23);
            this.details_BTN.TabIndex = 1;
            this.details_BTN.Text = "Details";
            this.details_BTN.UseVisualStyleBackColor = true;
            this.details_BTN.Click += new System.EventHandler(this.details_BTN_Click);
            // 
            // checkOut_BTN
            // 
            this.checkOut_BTN.Location = new System.Drawing.Point(87, 143);
            this.checkOut_BTN.Name = "checkOut_BTN";
            this.checkOut_BTN.Size = new System.Drawing.Size(75, 23);
            this.checkOut_BTN.TabIndex = 2;
            this.checkOut_BTN.Text = "Check Out";
            this.checkOut_BTN.UseVisualStyleBackColor = true;
            this.checkOut_BTN.Click += new System.EventHandler(this.checkOut_BTN_Click);
            // 
            // return_BTN
            // 
            this.return_BTN.Location = new System.Drawing.Point(168, 143);
            this.return_BTN.Name = "return_BTN";
            this.return_BTN.Size = new System.Drawing.Size(75, 23);
            this.return_BTN.TabIndex = 3;
            this.return_BTN.Text = "Return";
            this.return_BTN.UseVisualStyleBackColor = true;
            this.return_BTN.Click += new System.EventHandler(this.return_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 207);
            this.Controls.Add(this.yourBooks_GRB);
            this.Controls.Add(this.addBook_GRB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.addBook_GRB.ResumeLayout(false);
            this.addBook_GRB.PerformLayout();
            this.yourBooks_GRB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addBook_GRB;
        private System.Windows.Forms.Button addBook_BTN;
        private System.Windows.Forms.TextBox callNumber_TXT;
        private System.Windows.Forms.TextBox copyright_TXT;
        private System.Windows.Forms.TextBox publisher_TXT;
        private System.Windows.Forms.TextBox author_TXT;
        private System.Windows.Forms.TextBox title_TXT;
        private System.Windows.Forms.Label callNumber_LBL;
        private System.Windows.Forms.Label copyright_LBL;
        private System.Windows.Forms.Label publisher_LBL;
        private System.Windows.Forms.Label author_LBL;
        private System.Windows.Forms.Label title_LBL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox yourBooks_GRB;
        private System.Windows.Forms.Button return_BTN;
        private System.Windows.Forms.Button checkOut_BTN;
        private System.Windows.Forms.Button details_BTN;
        private System.Windows.Forms.ListBox books_LBX;
    }
}

