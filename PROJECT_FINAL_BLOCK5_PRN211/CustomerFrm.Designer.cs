namespace QuanLyKho
{
    partial class CustomerFrm
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
            dgCustomer = new DataGridView();
            txtCustomerID = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerPhone = new TextBox();
            labelCustomerID = new Label();
            CustomerName = new Label();
            CusPhone = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            lbSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(12, 241);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.RowTemplate.Height = 29;
            dgCustomer.Size = new Size(1302, 272);
            dgCustomer.TabIndex = 0;
            dgCustomer.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(135, 35);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(178, 27);
            txtCustomerID.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(1124, 35);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(178, 27);
            txtCustomerName.TabIndex = 2;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(656, 35);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(178, 27);
            txtCustomerPhone.TabIndex = 3;
            txtCustomerPhone.TextChanged += txtCustomerPhone_TextChanged;
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.Location = new Point(12, 42);
            labelCustomerID.Name = "labelCustomerID";
            labelCustomerID.Size = new Size(90, 20);
            labelCustomerID.TabIndex = 4;
            labelCustomerID.Text = "CustomerID:";
            labelCustomerID.Click += labelCustomerID_Click;
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.Location = new Point(1003, 42);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(115, 20);
            CustomerName.TabIndex = 5;
            CustomerName.Text = "CustomerName:";
            // 
            // CusPhone
            // 
            CusPhone.AutoSize = true;
            CusPhone.Location = new Point(533, 42);
            CusPhone.Name = "CusPhone";
            CusPhone.RightToLeft = RightToLeft.Yes;
            CusPhone.Size = new Size(121, 20);
            CusPhone.TabIndex = 6;
            CusPhone.Text = "Customer Phone ";
            CusPhone.Click += label3_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(16, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 46);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(196, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 46);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(383, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 46);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1168, 208);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(146, 27);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSearch.Location = new Point(1099, 208);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(63, 20);
            lbSearch.TabIndex = 17;
            lbSearch.Text = "Search :";
            lbSearch.Click += lbSearch_Click;
            // 
            // CustomerFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1326, 535);
            Controls.Add(lbSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(CusPhone);
            Controls.Add(CustomerName);
            Controls.Add(labelCustomerID);
            Controls.Add(txtCustomerPhone);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerID);
            Controls.Add(dgCustomer);
            Name = "CustomerFrm";
            Text = "CustomerFrm";
            Load += CustomerFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label CusPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
    }
}