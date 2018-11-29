namespace LibraryItems
{
    partial class BookForm
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
            this.bookTitle_LBL = new System.Windows.Forms.Label();
            this.bookPublisher_LBL = new System.Windows.Forms.Label();
            this.bookCopyrightYear_LBL = new System.Windows.Forms.Label();
            this.bookLoanPeriod_LBL = new System.Windows.Forms.Label();
            this.bookCallNumber_LBL = new System.Windows.Forms.Label();
            this.bookAuthor_LBL = new System.Windows.Forms.Label();
            this.bookTitle_TXT = new System.Windows.Forms.TextBox();
            this.bookPublisher_TXT = new System.Windows.Forms.TextBox();
            this.bookCopyrightYear_TXT = new System.Windows.Forms.TextBox();
            this.bookLoanPeriod_TXT = new System.Windows.Forms.TextBox();
            this.bookCallNumber_TXT = new System.Windows.Forms.TextBox();
            this.bookAuthor_TXT = new System.Windows.Forms.TextBox();
            this.bookOK_BTN = new System.Windows.Forms.Button();
            this.bookCancel_BTN = new System.Windows.Forms.Button();
            this.bookError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookError)).BeginInit();
            this.SuspendLayout();
            // 
            // bookTitle_LBL
            // 
            this.bookTitle_LBL.AutoSize = true;
            this.bookTitle_LBL.Location = new System.Drawing.Point(12, 9);
            this.bookTitle_LBL.Name = "bookTitle_LBL";
            this.bookTitle_LBL.Size = new System.Drawing.Size(39, 17);
            this.bookTitle_LBL.TabIndex = 0;
            this.bookTitle_LBL.Text = "Title:";
            // 
            // bookPublisher_LBL
            // 
            this.bookPublisher_LBL.AutoSize = true;
            this.bookPublisher_LBL.Location = new System.Drawing.Point(12, 47);
            this.bookPublisher_LBL.Name = "bookPublisher_LBL";
            this.bookPublisher_LBL.Size = new System.Drawing.Size(71, 17);
            this.bookPublisher_LBL.TabIndex = 1;
            this.bookPublisher_LBL.Text = "Publisher:";
            // 
            // bookCopyrightYear_LBL
            // 
            this.bookCopyrightYear_LBL.AutoSize = true;
            this.bookCopyrightYear_LBL.Location = new System.Drawing.Point(12, 85);
            this.bookCopyrightYear_LBL.Name = "bookCopyrightYear_LBL";
            this.bookCopyrightYear_LBL.Size = new System.Drawing.Size(106, 17);
            this.bookCopyrightYear_LBL.TabIndex = 2;
            this.bookCopyrightYear_LBL.Text = "Copyright Year:";
            // 
            // bookLoanPeriod_LBL
            // 
            this.bookLoanPeriod_LBL.AutoSize = true;
            this.bookLoanPeriod_LBL.Location = new System.Drawing.Point(12, 123);
            this.bookLoanPeriod_LBL.Name = "bookLoanPeriod_LBL";
            this.bookLoanPeriod_LBL.Size = new System.Drawing.Size(89, 17);
            this.bookLoanPeriod_LBL.TabIndex = 3;
            this.bookLoanPeriod_LBL.Text = "Loan Period:";
            // 
            // bookCallNumber_LBL
            // 
            this.bookCallNumber_LBL.AutoSize = true;
            this.bookCallNumber_LBL.Location = new System.Drawing.Point(12, 161);
            this.bookCallNumber_LBL.Name = "bookCallNumber_LBL";
            this.bookCallNumber_LBL.Size = new System.Drawing.Size(85, 17);
            this.bookCallNumber_LBL.TabIndex = 4;
            this.bookCallNumber_LBL.Text = "CallNumber:";
            // 
            // bookAuthor_LBL
            // 
            this.bookAuthor_LBL.AutoSize = true;
            this.bookAuthor_LBL.Location = new System.Drawing.Point(12, 199);
            this.bookAuthor_LBL.Name = "bookAuthor_LBL";
            this.bookAuthor_LBL.Size = new System.Drawing.Size(54, 17);
            this.bookAuthor_LBL.TabIndex = 5;
            this.bookAuthor_LBL.Text = "Author:";
            // 
            // bookTitle_TXT
            // 
            this.bookTitle_TXT.Location = new System.Drawing.Point(142, 6);
            this.bookTitle_TXT.Name = "bookTitle_TXT";
            this.bookTitle_TXT.Size = new System.Drawing.Size(178, 22);
            this.bookTitle_TXT.TabIndex = 6;
            this.bookTitle_TXT.Validating += new System.ComponentModel.CancelEventHandler(this.bookTitle_TXT_Validating);
            this.bookTitle_TXT.Validated += new System.EventHandler(this.bookTitle_TXT_Validated);
            // 
            // bookPublisher_TXT
            // 
            this.bookPublisher_TXT.Location = new System.Drawing.Point(142, 44);
            this.bookPublisher_TXT.Name = "bookPublisher_TXT";
            this.bookPublisher_TXT.Size = new System.Drawing.Size(178, 22);
            this.bookPublisher_TXT.TabIndex = 7;
            this.bookPublisher_TXT.Validating += new System.ComponentModel.CancelEventHandler(this.bookPublisher_TXT_Validating);
            // 
            // bookCopyrightYear_TXT
            // 
            this.bookCopyrightYear_TXT.Location = new System.Drawing.Point(142, 82);
            this.bookCopyrightYear_TXT.Name = "bookCopyrightYear_TXT";
            this.bookCopyrightYear_TXT.Size = new System.Drawing.Size(178, 22);
            this.bookCopyrightYear_TXT.TabIndex = 8;
            this.bookCopyrightYear_TXT.Validating += new System.ComponentModel.CancelEventHandler(this.bookCopyrightYear_TXT_Validating);
            this.bookCopyrightYear_TXT.Validated += new System.EventHandler(this.bookCopyrightYear_TXT_Validated);
            // 
            // bookLoanPeriod_TXT
            // 
            this.bookLoanPeriod_TXT.Location = new System.Drawing.Point(142, 120);
            this.bookLoanPeriod_TXT.Name = "bookLoanPeriod_TXT";
            this.bookLoanPeriod_TXT.Size = new System.Drawing.Size(178, 22);
            this.bookLoanPeriod_TXT.TabIndex = 9;
            this.bookLoanPeriod_TXT.Validating += new System.ComponentModel.CancelEventHandler(this.bookLoanPeriod_TXT_Validating);
            this.bookLoanPeriod_TXT.Validated += new System.EventHandler(this.bookLoanPeriod_TXT_Validated);
            // 
            // bookCallNumber_TXT
            // 
            this.bookCallNumber_TXT.Location = new System.Drawing.Point(142, 158);
            this.bookCallNumber_TXT.Name = "bookCallNumber_TXT";
            this.bookCallNumber_TXT.Size = new System.Drawing.Size(178, 22);
            this.bookCallNumber_TXT.TabIndex = 10;
            this.bookCallNumber_TXT.Validating += new System.ComponentModel.CancelEventHandler(this.bookCallNumber_TXT_Validating);
            this.bookCallNumber_TXT.Validated += new System.EventHandler(this.bookCallNumber_TXT_Validated);
            // 
            // bookAuthor_TXT
            // 
            this.bookAuthor_TXT.Location = new System.Drawing.Point(142, 196);
            this.bookAuthor_TXT.Name = "bookAuthor_TXT";
            this.bookAuthor_TXT.Size = new System.Drawing.Size(178, 22);
            this.bookAuthor_TXT.TabIndex = 11;
            this.bookAuthor_TXT.Validating += new System.ComponentModel.CancelEventHandler(this.bookAuthor_TXT_Validating);
            this.bookAuthor_TXT.Validated += new System.EventHandler(this.bookAuthor_TXT_Validated);
            // 
            // bookOK_BTN
            // 
            this.bookOK_BTN.Location = new System.Drawing.Point(43, 251);
            this.bookOK_BTN.Name = "bookOK_BTN";
            this.bookOK_BTN.Size = new System.Drawing.Size(75, 23);
            this.bookOK_BTN.TabIndex = 12;
            this.bookOK_BTN.Text = "OK";
            this.bookOK_BTN.UseVisualStyleBackColor = true;
            this.bookOK_BTN.Click += new System.EventHandler(this.bookOK_BTN_Click);
            // 
            // bookCancel_BTN
            // 
            this.bookCancel_BTN.Location = new System.Drawing.Point(220, 251);
            this.bookCancel_BTN.Name = "bookCancel_BTN";
            this.bookCancel_BTN.Size = new System.Drawing.Size(75, 23);
            this.bookCancel_BTN.TabIndex = 13;
            this.bookCancel_BTN.Text = "Cancel";
            this.bookCancel_BTN.UseVisualStyleBackColor = true;
            this.bookCancel_BTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bookCancel_BTN_MouseDown);
            // 
            // bookError
            // 
            this.bookError.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 300);
            this.Controls.Add(this.bookCancel_BTN);
            this.Controls.Add(this.bookOK_BTN);
            this.Controls.Add(this.bookAuthor_TXT);
            this.Controls.Add(this.bookCallNumber_TXT);
            this.Controls.Add(this.bookLoanPeriod_TXT);
            this.Controls.Add(this.bookCopyrightYear_TXT);
            this.Controls.Add(this.bookPublisher_TXT);
            this.Controls.Add(this.bookTitle_TXT);
            this.Controls.Add(this.bookAuthor_LBL);
            this.Controls.Add(this.bookCallNumber_LBL);
            this.Controls.Add(this.bookLoanPeriod_LBL);
            this.Controls.Add(this.bookCopyrightYear_LBL);
            this.Controls.Add(this.bookPublisher_LBL);
            this.Controls.Add(this.bookTitle_LBL);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.bookError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookTitle_LBL;
        private System.Windows.Forms.Label bookPublisher_LBL;
        private System.Windows.Forms.Label bookCopyrightYear_LBL;
        private System.Windows.Forms.Label bookLoanPeriod_LBL;
        private System.Windows.Forms.Label bookCallNumber_LBL;
        private System.Windows.Forms.Label bookAuthor_LBL;
        private System.Windows.Forms.TextBox bookTitle_TXT;
        private System.Windows.Forms.TextBox bookPublisher_TXT;
        private System.Windows.Forms.TextBox bookCopyrightYear_TXT;
        private System.Windows.Forms.TextBox bookLoanPeriod_TXT;
        private System.Windows.Forms.TextBox bookCallNumber_TXT;
        private System.Windows.Forms.TextBox bookAuthor_TXT;
        private System.Windows.Forms.Button bookOK_BTN;
        private System.Windows.Forms.Button bookCancel_BTN;
        private System.Windows.Forms.ErrorProvider bookError;
    }
}