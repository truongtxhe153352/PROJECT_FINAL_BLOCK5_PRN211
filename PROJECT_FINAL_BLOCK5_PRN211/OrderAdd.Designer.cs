namespace PROJECT_FINAL_BLOCK5_PRN211
{
    partial class OrderAdd
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerID = new TextBox();
            txtSearchCustomer = new TextBox();
            label1 = new Label();
            dtgCustomer = new DataGridView();
            panel2 = new Panel();
            txtTotal = new TextBox();
            numericQuantity = new NumericUpDown();
            txtPrice = new TextBox();
            dpkDateOrder = new DateTimePicker();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtSearchProduct = new TextBox();
            label6 = new Label();
            label2 = new Label();
            dtgProduct = new DataGridView();
            btnUpdate = new Button();
            btnOrder = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCustomer).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCustomerName);
            panel1.Controls.Add(txtCustomerID);
            panel1.Controls.Add(txtSearchCustomer);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtgCustomer);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 256);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(664, 122);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 7;
            label5.Text = "Customer ID";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(664, 178);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 6;
            label4.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(608, 35);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 5;
            label3.Text = "Search";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(799, 178);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(208, 27);
            txtCustomerName.TabIndex = 4;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(799, 115);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(208, 27);
            txtCustomerID.TabIndex = 3;
            txtCustomerID.TextChanged += textBox2_TextChanged;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(719, 35);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(208, 27);
            txtSearchCustomer.TabIndex = 2;
            txtSearchCustomer.TextChanged += txtSearchCustomer_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 26);
            label1.TabIndex = 1;
            label1.Text = "Customer";
            label1.Click += label1_Click;
            // 
            // dtgCustomer
            // 
            dtgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomer.Location = new Point(10, 49);
            dtgCustomer.Name = "dtgCustomer";
            dtgCustomer.RowHeadersWidth = 51;
            dtgCustomer.RowTemplate.Height = 29;
            dtgCustomer.Size = new Size(451, 204);
            dtgCustomer.TabIndex = 0;
            dtgCustomer.CellClick += dtgCustomer_CellClick;
            dtgCustomer.CellContentClick += dtgCustomer_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(numericQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(dpkDateOrder);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(txtProductID);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtSearchProduct);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtgProduct);
            panel2.Location = new Point(2, 262);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 409);
            panel2.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(799, 348);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(208, 27);
            txtTotal.TabIndex = 20;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(799, 300);
            numericQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(150, 27);
            numericQuantity.TabIndex = 19;
            numericQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.ValueChanged += numericQuantity_ValueChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(799, 244);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(208, 27);
            txtPrice.TabIndex = 18;
            // 
            // dpkDateOrder
            // 
            dpkDateOrder.Location = new Point(799, 198);
            dpkDateOrder.Name = "dpkDateOrder";
            dpkDateOrder.Size = new Size(250, 27);
            dpkDateOrder.TabIndex = 17;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(799, 148);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(208, 27);
            txtProductName.TabIndex = 16;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(799, 97);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(208, 27);
            txtProductID.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(664, 302);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 14;
            label12.Text = "Quantity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(664, 351);
            label11.Name = "label11";
            label11.Size = new Size(55, 28);
            label11.TabIndex = 13;
            label11.Text = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(665, 244);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 12;
            label10.Text = "Price";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(664, 198);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 11;
            label9.Text = "Order Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(665, 148);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 10;
            label8.Text = "Product Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(664, 104);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 9;
            label7.Text = "Product ID";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Location = new Point(719, 36);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(208, 27);
            txtSearchProduct.TabIndex = 8;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(608, 39);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 6;
            label6.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-B", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 21);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 2;
            label2.Text = "Product";
            // 
            // dtgProduct
            // 
            dtgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProduct.Location = new Point(10, 56);
            dtgProduct.Name = "dtgProduct";
            dtgProduct.RowHeadersWidth = 51;
            dtgProduct.RowTemplate.Height = 29;
            dtgProduct.Size = new Size(586, 319);
            dtgProduct.TabIndex = 1;
            dtgProduct.CellClick += dtgProduct_CellClick;
            dtgProduct.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(306, 688);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 49);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(455, 688);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(97, 49);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(610, 688);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 49);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // OrderAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 748);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(btnUpdate);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrderAdd";
            Text = "OrderAdd";
            Load += OrderAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCustomer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgCustomer;
        private Panel panel2;
        private DataGridView dtgProduct;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtCustomerName;
        private TextBox txtCustomerID;
        private TextBox txtSearchCustomer;
        private Label label2;
        private TextBox txtSearchProduct;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtTotal;
        private NumericUpDown numericQuantity;
        private TextBox txtPrice;
        private DateTimePicker dpkDateOrder;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Button btnUpdate;
        private Button btnOrder;
        private Button btnClear;
    }
}