namespace Login
{
    partial class CusHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.CusNameLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ChangePasswordbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactiondataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ReturnBookBtn = new System.Windows.Forms.Button();
            this.BorrowBookBtn = new System.Windows.Forms.Button();
            this.ExtendLoanBtn = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactiondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // CusNameLabel
            // 
            this.CusNameLabel.AutoSize = true;
            this.CusNameLabel.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CusNameLabel.Location = new System.Drawing.Point(176, 23);
            this.CusNameLabel.Name = "CusNameLabel";
            this.CusNameLabel.Size = new System.Drawing.Size(180, 27);
            this.CusNameLabel.TabIndex = 1;
            this.CusNameLabel.Text = "CustomerName";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(507, 27);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordbtn
            // 
            this.ChangePasswordbtn.Location = new System.Drawing.Point(371, 27);
            this.ChangePasswordbtn.Name = "ChangePasswordbtn";
            this.ChangePasswordbtn.Size = new System.Drawing.Size(104, 23);
            this.ChangePasswordbtn.TabIndex = 3;
            this.ChangePasswordbtn.Text = "ChangePassword";
            this.ChangePasswordbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(227, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "My Transaction:";
            // 
            // TransactiondataGridView
            // 
            this.TransactiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactiondataGridView.Location = new System.Drawing.Point(61, 131);
            this.TransactiondataGridView.Name = "TransactiondataGridView";
            this.TransactiondataGridView.RowTemplate.Height = 23;
            this.TransactiondataGridView.Size = new System.Drawing.Size(521, 153);
            this.TransactiondataGridView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(36, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can :";
            // 
            // ReturnBookBtn
            // 
            this.ReturnBookBtn.Location = new System.Drawing.Point(61, 380);
            this.ReturnBookBtn.Name = "ReturnBookBtn";
            this.ReturnBookBtn.Size = new System.Drawing.Size(105, 41);
            this.ReturnBookBtn.TabIndex = 7;
            this.ReturnBookBtn.Text = "Return Book";
            this.ReturnBookBtn.UseVisualStyleBackColor = true;
            // 
            // BorrowBookBtn
            // 
            this.BorrowBookBtn.Location = new System.Drawing.Point(270, 380);
            this.BorrowBookBtn.Name = "BorrowBookBtn";
            this.BorrowBookBtn.Size = new System.Drawing.Size(105, 41);
            this.BorrowBookBtn.TabIndex = 8;
            this.BorrowBookBtn.Text = "Borrow Book";
            this.BorrowBookBtn.UseVisualStyleBackColor = true;
            // 
            // ExtendLoanBtn
            // 
            this.ExtendLoanBtn.Location = new System.Drawing.Point(477, 380);
            this.ExtendLoanBtn.Name = "ExtendLoanBtn";
            this.ExtendLoanBtn.Size = new System.Drawing.Size(105, 41);
            this.ExtendLoanBtn.TabIndex = 9;
            this.ExtendLoanBtn.Text = "Extend the loan";
            this.ExtendLoanBtn.UseVisualStyleBackColor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(38, 68);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(29, 12);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Date";
            // 
            // CusHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ExtendLoanBtn);
            this.Controls.Add(this.BorrowBookBtn);
            this.Controls.Add(this.ReturnBookBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransactiondataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangePasswordbtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.CusNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "CusHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.TransactiondataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CusNameLabel;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ChangePasswordbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TransactiondataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReturnBookBtn;
        private System.Windows.Forms.Button BorrowBookBtn;
        private System.Windows.Forms.Button ExtendLoanBtn;
        private System.Windows.Forms.Label DateLabel;
    }
}