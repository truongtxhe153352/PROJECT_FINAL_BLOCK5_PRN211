namespace PROJECT_FINAL_BLOCK5_PRN211
{
    partial class ProductFrm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            cbCategory = new ComboBox();
            dtgProduct = new DataGridView();
            txtFilter = new TextBox();
            Search = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            button1 = new Button();
            numericQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtgProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(740, 38);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Category";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(740, 106);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 102);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 39);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 102);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "Product Name";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(122, 32);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(209, 27);
            txtProductId.TabIndex = 6;
            txtProductId.TextChanged += textBox1_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(122, 99);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(209, 27);
            txtProductName.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(477, 95);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 27);
            txtPrice.TabIndex = 9;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(852, 106);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(209, 109);
            txtDescription.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(852, 42);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(185, 28);
            cbCategory.TabIndex = 12;
            cbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dtgProduct
            // 
            dtgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProduct.Location = new Point(29, 358);
            dtgProduct.Name = "dtgProduct";
            dtgProduct.RowHeadersWidth = 51;
            dtgProduct.RowTemplate.Height = 29;
            dtgProduct.Size = new Size(1032, 302);
            dtgProduct.TabIndex = 13;
            dtgProduct.CellClick += dtgProduct_CellClick;
            dtgProduct.CellContentClick += dtgProduct_CellContentClick;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(828, 301);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Search here";
            txtFilter.Size = new Size(233, 27);
            txtFilter.TabIndex = 14;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(740, 301);
            Search.Name = "Search";
            Search.Size = new Size(53, 20);
            Search.TabIndex = 15;
            Search.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 174);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 41);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(439, 174);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 41);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(224, 174);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 41);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(635, 174);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 41);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 292);
            button1.Name = "button1";
            button1.Size = new Size(99, 50);
            button1.TabIndex = 20;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(477, 31);
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(209, 27);
            numericQuantity.TabIndex = 21;
            // 
            // ProductFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1097, 688);
            Controls.Add(numericQuantity);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(Search);
            Controls.Add(txtFilter);
            Controls.Add(dtgProduct);
            Controls.Add(cbCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductFrm";
            Text = "ProductFrm";
            Load += ProductFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private ComboBox cbCategory;
        private DataGridView dtgProduct;
        private TextBox txtFilter;
        private Label Search;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button button1;
        private NumericUpDown numericQuantity;
    }
}