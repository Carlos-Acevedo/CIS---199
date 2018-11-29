namespace LibraryItems
{
    partial class PatronForm
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
            this.patronName_LBL = new System.Windows.Forms.Label();
            this.patronID_LBL = new System.Windows.Forms.Label();
            this.patronName_TXT = new System.Windows.Forms.TextBox();
            this.patronID_TXT = new System.Windows.Forms.TextBox();
            this.patronOk_BTN = new System.Windows.Forms.Button();
            this.patronCancel_BTN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // patronName_LBL
            // 
            this.patronName_LBL.AutoSize = true;
            this.patronName_LBL.Location = new System.Drawing.Point(12, 9);
            this.patronName_LBL.Name = "patronName_LBL";
            this.patronName_LBL.Size = new System.Drawing.Size(49, 17);
            this.patronName_LBL.TabIndex = 0;
            this.patronName_LBL.Text = "Name:";
            // 
            // patronID_LBL
            // 
            this.patronID_LBL.AutoSize = true;
            this.patronID_LBL.Location = new System.Drawing.Point(12, 47);
            this.patronID_LBL.Name = "patronID_LBL";
            this.patronID_LBL.Size = new System.Drawing.Size(25, 17);
            this.patronID_LBL.TabIndex = 1;
            this.patronID_LBL.Text = "ID:";
            // 
            // patronName_TXT
            // 
            this.patronName_TXT.Location = new System.Drawing.Point(67, 12);
            this.patronName_TXT.Name = "patronName_TXT";
            this.patronName_TXT.Size = new System.Drawing.Size(152, 22);
            this.patronName_TXT.TabIndex = 2;
            this.patronName_TXT.Validating += new System.ComponentModel.CancelEventHandler(this.patronName_TXT_Validating);
            this.patronName_TXT.Validated += new System.EventHandler(this.patronName_TXT_Validated);
            // 
            // patronID_TXT
            // 
            this.patronID_TXT.Location = new System.Drawing.Point(67, 47);
            this.patronID_TXT.Name = "patronID_TXT";
            this.patronID_TXT.Size = new System.Drawing.Size(152, 22);
            this.patronID_TXT.TabIndex = 3;
            this.patronID_TXT.Validating += new System.ComponentModel.CancelEventHandler(this.patronID_TXT_Validating);
            this.patronID_TXT.Validated += new System.EventHandler(this.patronID_TXT_Validated);
            // 
            // patronOk_BTN
            // 
            this.patronOk_BTN.Location = new System.Drawing.Point(15, 93);
            this.patronOk_BTN.Name = "patronOk_BTN";
            this.patronOk_BTN.Size = new System.Drawing.Size(75, 23);
            this.patronOk_BTN.TabIndex = 4;
            this.patronOk_BTN.Text = "OK";
            this.patronOk_BTN.UseVisualStyleBackColor = true;
            this.patronOk_BTN.Click += new System.EventHandler(this.patronOk_BTN_Click);
            // 
            // patronCancel_BTN
            // 
            this.patronCancel_BTN.Location = new System.Drawing.Point(144, 93);
            this.patronCancel_BTN.Name = "patronCancel_BTN";
            this.patronCancel_BTN.Size = new System.Drawing.Size(75, 23);
            this.patronCancel_BTN.TabIndex = 5;
            this.patronCancel_BTN.Text = "Cancel";
            this.patronCancel_BTN.UseVisualStyleBackColor = true;
            this.patronCancel_BTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.patronCancel_BTN_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 140);
            this.Controls.Add(this.patronCancel_BTN);
            this.Controls.Add(this.patronOk_BTN);
            this.Controls.Add(this.patronID_TXT);
            this.Controls.Add(this.patronName_TXT);
            this.Controls.Add(this.patronID_LBL);
            this.Controls.Add(this.patronName_LBL);
            this.Name = "PatronForm";
            this.Text = "Patron";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patronName_LBL;
        private System.Windows.Forms.Label patronID_LBL;
        private System.Windows.Forms.TextBox patronName_TXT;
        private System.Windows.Forms.TextBox patronID_TXT;
        private System.Windows.Forms.Button patronOk_BTN;
        private System.Windows.Forms.Button patronCancel_BTN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}