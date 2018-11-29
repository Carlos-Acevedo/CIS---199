namespace Program2
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
            this.priorityERSC_LBL = new System.Windows.Forms.Label();
            this.lastName_LBL = new System.Windows.Forms.Label();
            this.creditHours_LBL = new System.Windows.Forms.Label();
            this.lastName_TXT = new System.Windows.Forms.TextBox();
            this.creditHours_TXT = new System.Windows.Forms.TextBox();
            this.oK_BTN = new System.Windows.Forms.Button();
            this.scheduleOutPut_LBL = new System.Windows.Forms.Label();
            this.clear_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priorityERSC_LBL
            // 
            this.priorityERSC_LBL.AutoSize = true;
            this.priorityERSC_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityERSC_LBL.Location = new System.Drawing.Point(68, 29);
            this.priorityERSC_LBL.Name = "priorityERSC_LBL";
            this.priorityERSC_LBL.Size = new System.Drawing.Size(502, 24);
            this.priorityERSC_LBL.TabIndex = 0;
            this.priorityERSC_LBL.Text = "Priority Early Registration Schedule for Continuing Students";
            // 
            // lastName_LBL
            // 
            this.lastName_LBL.AutoSize = true;
            this.lastName_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_LBL.Location = new System.Drawing.Point(229, 100);
            this.lastName_LBL.Name = "lastName_LBL";
            this.lastName_LBL.Size = new System.Drawing.Size(84, 18);
            this.lastName_LBL.TabIndex = 1;
            this.lastName_LBL.Text = "Last Name:";
            // 
            // creditHours_LBL
            // 
            this.creditHours_LBL.AutoSize = true;
            this.creditHours_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditHours_LBL.Location = new System.Drawing.Point(217, 133);
            this.creditHours_LBL.Name = "creditHours_LBL";
            this.creditHours_LBL.Size = new System.Drawing.Size(96, 18);
            this.creditHours_LBL.TabIndex = 2;
            this.creditHours_LBL.Text = "Credit Hours:";
            // 
            // lastName_TXT
            // 
            this.lastName_TXT.Location = new System.Drawing.Point(319, 101);
            this.lastName_TXT.Name = "lastName_TXT";
            this.lastName_TXT.Size = new System.Drawing.Size(100, 20);
            this.lastName_TXT.TabIndex = 3;
            // 
            // creditHours_TXT
            // 
            this.creditHours_TXT.Location = new System.Drawing.Point(319, 134);
            this.creditHours_TXT.Name = "creditHours_TXT";
            this.creditHours_TXT.Size = new System.Drawing.Size(100, 20);
            this.creditHours_TXT.TabIndex = 4;
            // 
            // oK_BTN
            // 
            this.oK_BTN.Location = new System.Drawing.Point(283, 182);
            this.oK_BTN.Name = "oK_BTN";
            this.oK_BTN.Size = new System.Drawing.Size(75, 23);
            this.oK_BTN.TabIndex = 5;
            this.oK_BTN.Text = "OK";
            this.oK_BTN.UseVisualStyleBackColor = true;
            this.oK_BTN.Click += new System.EventHandler(this.oK_BTN_Click);
            // 
            // scheduleOutPut_LBL
            // 
            this.scheduleOutPut_LBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scheduleOutPut_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleOutPut_LBL.Location = new System.Drawing.Point(118, 220);
            this.scheduleOutPut_LBL.Name = "scheduleOutPut_LBL";
            this.scheduleOutPut_LBL.Size = new System.Drawing.Size(393, 23);
            this.scheduleOutPut_LBL.TabIndex = 6;
            this.scheduleOutPut_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clear_BTN
            // 
            this.clear_BTN.Location = new System.Drawing.Point(283, 262);
            this.clear_BTN.Name = "clear_BTN";
            this.clear_BTN.Size = new System.Drawing.Size(75, 23);
            this.clear_BTN.TabIndex = 7;
            this.clear_BTN.Text = "Clear";
            this.clear_BTN.UseVisualStyleBackColor = true;
            this.clear_BTN.Click += new System.EventHandler(this.clear_BTN_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.oK_BTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear_BTN;
            this.ClientSize = new System.Drawing.Size(630, 322);
            this.Controls.Add(this.clear_BTN);
            this.Controls.Add(this.scheduleOutPut_LBL);
            this.Controls.Add(this.oK_BTN);
            this.Controls.Add(this.creditHours_TXT);
            this.Controls.Add(this.lastName_TXT);
            this.Controls.Add(this.creditHours_LBL);
            this.Controls.Add(this.lastName_LBL);
            this.Controls.Add(this.priorityERSC_LBL);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priorityERSC_LBL;
        private System.Windows.Forms.Label lastName_LBL;
        private System.Windows.Forms.Label creditHours_LBL;
        private System.Windows.Forms.TextBox lastName_TXT;
        private System.Windows.Forms.TextBox creditHours_TXT;
        private System.Windows.Forms.Button oK_BTN;
        private System.Windows.Forms.Label scheduleOutPut_LBL;
        private System.Windows.Forms.Button clear_BTN;
    }
}

