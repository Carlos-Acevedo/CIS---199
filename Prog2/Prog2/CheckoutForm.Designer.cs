namespace LibraryItems
{
    partial class CheckoutForm
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
            this.item_ComboBox = new System.Windows.Forms.ComboBox();
            this.patron_ComboBox = new System.Windows.Forms.ComboBox();
            this.checkoutOK_BTN = new System.Windows.Forms.Button();
            this.checkoutCancel_BTN = new System.Windows.Forms.Button();
            this.CheckOutError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutError)).BeginInit();
            this.SuspendLayout();
            // 
            // item_ComboBox
            // 
            this.item_ComboBox.FormattingEnabled = true;
            this.item_ComboBox.Location = new System.Drawing.Point(12, 43);
            this.item_ComboBox.Name = "item_ComboBox";
            this.item_ComboBox.Size = new System.Drawing.Size(361, 24);
            this.item_ComboBox.TabIndex = 0;
            this.item_ComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.item_ComboBox_Validating);
            this.item_ComboBox.Validated += new System.EventHandler(this.item_ComboBox_Validated);
            // 
            // patron_ComboBox
            // 
            this.patron_ComboBox.FormattingEnabled = true;
            this.patron_ComboBox.Location = new System.Drawing.Point(12, 156);
            this.patron_ComboBox.Name = "patron_ComboBox";
            this.patron_ComboBox.Size = new System.Drawing.Size(225, 24);
            this.patron_ComboBox.TabIndex = 1;
            this.patron_ComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.patron_ComboBox_Validating);
            this.patron_ComboBox.Validated += new System.EventHandler(this.patron_ComboBox_Validated);
            // 
            // checkoutOK_BTN
            // 
            this.checkoutOK_BTN.Location = new System.Drawing.Point(76, 225);
            this.checkoutOK_BTN.Name = "checkoutOK_BTN";
            this.checkoutOK_BTN.Size = new System.Drawing.Size(75, 23);
            this.checkoutOK_BTN.TabIndex = 2;
            this.checkoutOK_BTN.Text = "OK";
            this.checkoutOK_BTN.UseVisualStyleBackColor = true;
            this.checkoutOK_BTN.Click += new System.EventHandler(this.checkoutOK_BTN_Click);
            // 
            // checkoutCancel_BTN
            // 
            this.checkoutCancel_BTN.Location = new System.Drawing.Point(243, 225);
            this.checkoutCancel_BTN.Name = "checkoutCancel_BTN";
            this.checkoutCancel_BTN.Size = new System.Drawing.Size(75, 23);
            this.checkoutCancel_BTN.TabIndex = 3;
            this.checkoutCancel_BTN.Text = "Cancel";
            this.checkoutCancel_BTN.UseVisualStyleBackColor = true;
            this.checkoutCancel_BTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkoutCancel_BTN_MouseDown);
            // 
            // CheckOutError
            // 
            this.CheckOutError.ContainerControl = this;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 267);
            this.Controls.Add(this.checkoutCancel_BTN);
            this.Controls.Add(this.checkoutOK_BTN);
            this.Controls.Add(this.patron_ComboBox);
            this.Controls.Add(this.item_ComboBox);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox item_ComboBox;
        private System.Windows.Forms.ComboBox patron_ComboBox;
        private System.Windows.Forms.Button checkoutOK_BTN;
        private System.Windows.Forms.Button checkoutCancel_BTN;
        private System.Windows.Forms.ErrorProvider CheckOutError;
    }
}