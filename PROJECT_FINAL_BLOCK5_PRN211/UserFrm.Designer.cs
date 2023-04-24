namespace QuanLyKho
{
    partial class UserFrm
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
            dgUser = new DataGridView();
            txtUserID = new TextBox();
            txtUserName = new TextBox();
            txtUserFullname = new TextBox();
            txtUserPass = new TextBox();
            txtUserPhone = new TextBox();
            lbUserID = new Label();
            lbUserName = new Label();
            lbFullname = new Label();
            lbUserPassword = new Label();
            lbUserPhone = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lbSearch = new Label();
            txtSearch = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUser).BeginInit();
            SuspendLayout();
            // 
            // dgUser
            // 
            dgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUser.Location = new Point(12, 194);
            dgUser.Name = "dgUser";
            dgUser.RowHeadersWidth = 51;
            dgUser.RowTemplate.Height = 29;
            dgUser.Size = new Size(1302, 300);
            dgUser.TabIndex = 0;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(122, 8);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(146, 27);
            txtUserID.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(571, 8);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(146, 27);
            txtUserName.TabIndex = 2;
            // 
            // txtUserFullname
            // 
            txtUserFullname.Location = new Point(957, 12);
            txtUserFullname.Name = "txtUserFullname";
            txtUserFullname.Size = new Size(146, 27);
            txtUserFullname.TabIndex = 3;
            // 
            // txtUserPass
            // 
            txtUserPass.Location = new Point(571, 54);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.Size = new Size(146, 27);
            txtUserPass.TabIndex = 4;
            // 
            // txtUserPhone
            // 
            txtUserPhone.Location = new Point(122, 54);
            txtUserPhone.Name = "txtUserPhone";
            txtUserPhone.Size = new Size(146, 27);
            txtUserPhone.TabIndex = 5;
            txtUserPhone.TextChanged += txtUserPhone_TextChanged;
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new Point(12, 19);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(60, 20);
            lbUserID.TabIndex = 6;
            lbUserID.Text = "UserID :";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(476, 15);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(89, 20);
            lbUserName.TabIndex = 7;
            lbUserName.Text = "User Name :";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new Point(859, 19);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(83, 20);
            lbFullname.TabIndex = 8;
            lbFullname.Text = "Full Name :";
            // 
            // lbUserPassword
            // 
            lbUserPassword.AutoSize = true;
            lbUserPassword.Location = new Point(488, 61);
            lbUserPassword.Name = "lbUserPassword";
            lbUserPassword.Size = new Size(77, 20);
            lbUserPassword.TabIndex = 9;
            lbUserPassword.Text = "Password :";
            // 
            // lbUserPhone
            // 
            lbUserPhone.AutoSize = true;
            lbUserPhone.Location = new Point(12, 61);
            lbUserPhone.Name = "lbUserPhone";
            lbUserPhone.Size = new Size(90, 20);
            lbUserPhone.TabIndex = 10;
            lbUserPhone.Text = "User Phone :";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(12, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 46);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(189, 142);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 46);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(370, 142);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 46);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSearch.Location = new Point(1040, 160);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(63, 20);
            lbSearch.TabIndex = 14;
            lbSearch.Text = "Search :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1109, 157);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(205, 27);
            txtSearch.TabIndex = 15;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(1220, 500);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // UserFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1326, 535);
            Controls.Add(btnBack);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lbUserPhone);
            Controls.Add(lbUserPassword);
            Controls.Add(lbFullname);
            Controls.Add(lbUserName);
            Controls.Add(lbUserID);
            Controls.Add(txtUserPhone);
            Controls.Add(txtUserPass);
            Controls.Add(txtUserFullname);
            Controls.Add(txtUserName);
            Controls.Add(txtUserID);
            Controls.Add(dgUser);
            Name = "UserFrm";
            Text = "UserFrm";
            Load += UserFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgUser;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserFullname;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbUserPassword;
        private System.Windows.Forms.Label lbUserPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private Button btnBack;
    }
}