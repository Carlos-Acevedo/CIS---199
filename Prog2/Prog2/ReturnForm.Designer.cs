namespace LibraryItems
{
    partial class ReturnForm
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
            this.returnItem_ComboBox = new System.Windows.Forms.ComboBox();
            this.returnOK_BTN = new System.Windows.Forms.Button();
            this.returnCancel_BTN = new System.Windows.Forms.Button();
            this.returnError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.returnError)).BeginInit();
            this.SuspendLayout();
            // 
            // returnItem_ComboBox
            // 
            this.returnItem_ComboBox.FormattingEnabled = true;
            this.returnItem_ComboBox.Location = new System.Drawing.Point(58, 53);
            this.returnItem_ComboBox.Name = "returnItem_ComboBox";
            this.returnItem_ComboBox.Size = new System.Drawing.Size(301, 24);
            this.returnItem_ComboBox.TabIndex = 0;
            this.returnItem_ComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.returnItem_ComboBox_Validating);
            this.returnItem_ComboBox.Validated += new System.EventHandler(this.returnItem_ComboBox_Validated);
            // 
            // returnOK_BTN
            // 
            this.returnOK_BTN.Location = new System.Drawing.Point(58, 136);
            this.returnOK_BTN.Name = "returnOK_BTN";
            this.returnOK_BTN.Size = new System.Drawing.Size(75, 23);
            this.returnOK_BTN.TabIndex = 1;
            this.returnOK_BTN.Text = "OK";
            this.returnOK_BTN.UseVisualStyleBackColor = true;
            this.returnOK_BTN.Click += new System.EventHandler(this.returnOK_BTN_Click);
            // 
            // returnCancel_BTN
            // 
            this.returnCancel_BTN.Location = new System.Drawing.Point(284, 136);
            this.returnCancel_BTN.Name = "returnCancel_BTN";
            this.returnCancel_BTN.Size = new System.Drawing.Size(75, 23);
            this.returnCancel_BTN.TabIndex = 2;
            this.returnCancel_BTN.Text = "Cancel";
            this.returnCancel_BTN.UseVisualStyleBackColor = true;
            this.returnCancel_BTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.returnCancel_BTN_MouseDown);
            // 
            // returnError
            // 
            this.returnError.ContainerControl = this;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 253);
            this.Controls.Add(this.returnCancel_BTN);
            this.Controls.Add(this.returnOK_BTN);
            this.Controls.Add(this.returnItem_ComboBox);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.returnError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox returnItem_ComboBox;
        private System.Windows.Forms.Button returnOK_BTN;
        private System.Windows.Forms.Button returnCancel_BTN;
        private System.Windows.Forms.ErrorProvider returnError;
    }
}