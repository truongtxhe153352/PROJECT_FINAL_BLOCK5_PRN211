namespace PROJECT_FINAL_BLOCK5_PRN211
{
    partial class OrderFrm
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
            txtOrderId = new TextBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dtgOrder = new DataGridView();
            numericQuantity = new NumericUpDown();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 103);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Order quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(757, 156);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Search";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(161, 28);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Size = new Size(176, 27);
            txtOrderId.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(839, 153);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(187, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(170, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 43);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD NEW ORDER";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(543, 176);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 43);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(379, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button3_Click;
            // 
            // dtgOrder
            // 
            dtgOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOrder.Location = new Point(12, 255);
            dtgOrder.Name = "dtgOrder";
            dtgOrder.RowHeadersWidth = 51;
            dtgOrder.RowTemplate.Height = 29;
            dtgOrder.Size = new Size(1032, 257);
            dtgOrder.TabIndex = 9;
            dtgOrder.CellClick += dtgOrder_CellClick;
            dtgOrder.CellContentClick += dtgOrder_CellContentClick;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(161, 101);
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(176, 27);
            numericQuantity.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(21, 176);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 43);
            btnBack.TabIndex = 11;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // OrderFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1056, 524);
            Controls.Add(btnBack);
            Controls.Add(numericQuantity);
            Controls.Add(dtgOrder);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(txtOrderId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderFrm";
            Text = "OrderFrm";
            Load += OrderFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtOrderId;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dtgOrder;
        private NumericUpDown numericQuantity;
        private Button btnBack;
    }
}