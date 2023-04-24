namespace QuanLyKho
{
    partial class CategoryFrm
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
            dgCategory = new DataGridView();
            txtCateID = new TextBox();
            txtCateName = new TextBox();
            txtCateID1 = new Label();
            txtCateName1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgCategory).BeginInit();
            SuspendLayout();
            // 
            // dgCategory
            // 
            dgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategory.Location = new Point(380, 12);
            dgCategory.Name = "dgCategory";
            dgCategory.RowHeadersWidth = 51;
            dgCategory.RowTemplate.Height = 29;
            dgCategory.Size = new Size(825, 435);
            dgCategory.TabIndex = 0;
            dgCategory.CellContentClick += dgCategory_CellContentClick;
            // 
            // txtCateID
            // 
            txtCateID.Location = new Point(172, 55);
            txtCateID.Name = "txtCateID";
            txtCateID.Size = new Size(125, 27);
            txtCateID.TabIndex = 1;
            // 
            // txtCateName
            // 
            txtCateName.Location = new Point(172, 123);
            txtCateName.Name = "txtCateName";
            txtCateName.Size = new Size(125, 27);
            txtCateName.TabIndex = 2;
            // 
            // txtCateID1
            // 
            txtCateID1.AutoSize = true;
            txtCateID1.Location = new Point(45, 55);
            txtCateID1.Name = "txtCateID1";
            txtCateID1.Size = new Size(91, 20);
            txtCateID1.TabIndex = 3;
            txtCateID1.Text = "Category ID:";
            // 
            // txtCateName1
            // 
            txtCateName1.AutoSize = true;
            txtCateName1.Location = new Point(45, 123);
            txtCateName1.Name = "txtCateName1";
            txtCateName1.Size = new Size(112, 20);
            txtCateName1.TabIndex = 4;
            txtCateName1.Text = "CategoryName:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(407, 453);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(591, 453);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 46);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(786, 453);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 46);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1020, 477);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 8;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1080, 470);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // CategoryFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1326, 535);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCateName1);
            Controls.Add(txtCateID1);
            Controls.Add(txtCateName);
            Controls.Add(txtCateID);
            Controls.Add(dgCategory);
            Name = "CategoryFrm";
            Text = "CategoryFrm";
            Load += CategoryFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.TextBox txtCateID;
        private System.Windows.Forms.TextBox txtCateName;
        private System.Windows.Forms.Label txtCateID1;
        private System.Windows.Forms.Label txtCateName1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}