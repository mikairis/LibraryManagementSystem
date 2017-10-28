namespace Login
{
    partial class StaffHome
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ChangePasswordbtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewBookListBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ViewCusListBtn = new System.Windows.Forms.Button();
            this.ViewExtentionAppBtn = new System.Windows.Forms.Button();
            this.GetReportBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ViewIssueTranBtn = new System.Windows.Forms.Button();
            this.ViewPaymentTranBtn = new System.Windows.Forms.Button();
            this.ViewAuthorListBtn = new System.Windows.Forms.Button();
            this.ViewPublisherListbtn = new System.Windows.Forms.Button();
            this.ViewCountryListBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(63, 79);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 17);
            this.DateLabel.TabIndex = 17;
            this.DateLabel.Text = "Date";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(93, 312);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1081, 360);
            this.dataGridView.TabIndex = 16;
            // 
            // ChangePasswordbtn
            // 
            this.ChangePasswordbtn.Location = new System.Drawing.Point(507, 24);
            this.ChangePasswordbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChangePasswordbtn.Name = "ChangePasswordbtn";
            this.ChangePasswordbtn.Size = new System.Drawing.Size(139, 31);
            this.ChangePasswordbtn.TabIndex = 14;
            this.ChangePasswordbtn.Text = "ChangePassword";
            this.ChangePasswordbtn.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(688, 24);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(100, 31);
            this.LogoutBtn.TabIndex = 13;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.AutoSize = true;
            this.StaffNameLabel.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StaffNameLabel.Location = new System.Drawing.Point(247, 19);
            this.StaffNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.Size = new System.Drawing.Size(168, 34);
            this.StaffNameLabel.TabIndex = 12;
            this.StaffNameLabel.Text = "StaffName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome!";
            // 
            // ViewBookListBtn
            // 
            this.ViewBookListBtn.Location = new System.Drawing.Point(93, 101);
            this.ViewBookListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewBookListBtn.Name = "ViewBookListBtn";
            this.ViewBookListBtn.Size = new System.Drawing.Size(247, 51);
            this.ViewBookListBtn.TabIndex = 18;
            this.ViewBookListBtn.Text = "View Book List";
            this.ViewBookListBtn.UseVisualStyleBackColor = true;
            this.ViewBookListBtn.Click += new System.EventHandler(this.ViewBookListBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBtn.Location = new System.Drawing.Point(773, 248);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(229, 36);
            this.SearchBtn.TabIndex = 20;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBox.Location = new System.Drawing.Point(376, 248);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(372, 36);
            this.SearchBox.TabIndex = 19;
            // 
            // ViewCusListBtn
            // 
            this.ViewCusListBtn.Location = new System.Drawing.Point(376, 101);
            this.ViewCusListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewCusListBtn.Name = "ViewCusListBtn";
            this.ViewCusListBtn.Size = new System.Drawing.Size(247, 51);
            this.ViewCusListBtn.TabIndex = 21;
            this.ViewCusListBtn.Text = "View Customer List";
            this.ViewCusListBtn.UseVisualStyleBackColor = true;
            // 
            // ViewExtentionAppBtn
            // 
            this.ViewExtentionAppBtn.Location = new System.Drawing.Point(652, 101);
            this.ViewExtentionAppBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewExtentionAppBtn.Name = "ViewExtentionAppBtn";
            this.ViewExtentionAppBtn.Size = new System.Drawing.Size(247, 51);
            this.ViewExtentionAppBtn.TabIndex = 22;
            this.ViewExtentionAppBtn.Text = "View Extention Application";
            this.ViewExtentionAppBtn.UseVisualStyleBackColor = true;
            this.ViewExtentionAppBtn.Click += new System.EventHandler(this.ViewExtentionAppBtn_Click);
            // 
            // GetReportBtn
            // 
            this.GetReportBtn.Location = new System.Drawing.Point(816, 24);
            this.GetReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GetReportBtn.Name = "GetReportBtn";
            this.GetReportBtn.Size = new System.Drawing.Size(149, 31);
            this.GetReportBtn.TabIndex = 23;
            this.GetReportBtn.Text = "Get Report";
            this.GetReportBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(220, 692);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(120, 51);
            this.AddBtn.TabIndex = 24;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(560, 692);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(120, 51);
            this.UpdateBtn.TabIndex = 25;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(883, 692);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(120, 51);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ViewIssueTranBtn
            // 
            this.ViewIssueTranBtn.Location = new System.Drawing.Point(928, 101);
            this.ViewIssueTranBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewIssueTranBtn.Name = "ViewIssueTranBtn";
            this.ViewIssueTranBtn.Size = new System.Drawing.Size(247, 51);
            this.ViewIssueTranBtn.TabIndex = 27;
            this.ViewIssueTranBtn.Text = "View IssueTran";
            this.ViewIssueTranBtn.UseVisualStyleBackColor = true;
            // 
            // ViewPaymentTranBtn
            // 
            this.ViewPaymentTranBtn.Location = new System.Drawing.Point(93, 179);
            this.ViewPaymentTranBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewPaymentTranBtn.Name = "ViewPaymentTranBtn";
            this.ViewPaymentTranBtn.Size = new System.Drawing.Size(247, 51);
            this.ViewPaymentTranBtn.TabIndex = 28;
            this.ViewPaymentTranBtn.Text = "View PaymentTran";
            this.ViewPaymentTranBtn.UseVisualStyleBackColor = true;
            // 
            // ViewAuthorListBtn
            // 
            this.ViewAuthorListBtn.Location = new System.Drawing.Point(376, 179);
            this.ViewAuthorListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewAuthorListBtn.Name = "ViewAuthorListBtn";
            this.ViewAuthorListBtn.Size = new System.Drawing.Size(247, 51);
            this.ViewAuthorListBtn.TabIndex = 29;
            this.ViewAuthorListBtn.Text = "View Author List";
            this.ViewAuthorListBtn.UseVisualStyleBackColor = true;
            // 
            // ViewPublisherListbtn
            // 
            this.ViewPublisherListbtn.Location = new System.Drawing.Point(652, 179);
            this.ViewPublisherListbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewPublisherListbtn.Name = "ViewPublisherListbtn";
            this.ViewPublisherListbtn.Size = new System.Drawing.Size(247, 51);
            this.ViewPublisherListbtn.TabIndex = 30;
            this.ViewPublisherListbtn.Text = "View Publisher List";
            this.ViewPublisherListbtn.UseVisualStyleBackColor = true;
            // 
            // ViewCountryListBtn
            // 
            this.ViewCountryListBtn.Location = new System.Drawing.Point(928, 179);
            this.ViewCountryListBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewCountryListBtn.Name = "ViewCountryListBtn";
            this.ViewCountryListBtn.Size = new System.Drawing.Size(247, 51);
            this.ViewCountryListBtn.TabIndex = 31;
            this.ViewCountryListBtn.Text = "View Country List";
            this.ViewCountryListBtn.UseVisualStyleBackColor = true;
            // 
            // StaffHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 759);
            this.Controls.Add(this.ViewCountryListBtn);
            this.Controls.Add(this.ViewPublisherListbtn);
            this.Controls.Add(this.ViewAuthorListBtn);
            this.Controls.Add(this.ViewPaymentTranBtn);
            this.Controls.Add(this.ViewIssueTranBtn);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.GetReportBtn);
            this.Controls.Add(this.ViewExtentionAppBtn);
            this.Controls.Add(this.ViewCusListBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ViewBookListBtn);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ChangePasswordbtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.StaffNameLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffHome";
            this.Text = "StaffHome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ChangePasswordbtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewBookListBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button ViewCusListBtn;
        private System.Windows.Forms.Button ViewExtentionAppBtn;
        private System.Windows.Forms.Button GetReportBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ViewIssueTranBtn;
        private System.Windows.Forms.Button ViewPaymentTranBtn;
        private System.Windows.Forms.Button ViewAuthorListBtn;
        private System.Windows.Forms.Button ViewPublisherListbtn;
        private System.Windows.Forms.Button ViewCountryListBtn;
    }
}