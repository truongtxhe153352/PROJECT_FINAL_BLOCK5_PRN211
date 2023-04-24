namespace QuanLyKho
{
    partial class MainForm
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
            btnProduct = new Button();
            btnCustomer = new Button();
            btnCategory = new Button();
            btnUser = new Button();
            panel1 = new Panel();
            btnOrder = new Button();
            panelMain = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.Location = new Point(41, 12);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(156, 71);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Products";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.Location = new Point(291, 12);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(156, 71);
            btnCustomer.TabIndex = 1;
            btnCustomer.Text = "Customers";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategory.Location = new Point(603, 12);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(156, 71);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Categorys";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.Location = new Point(888, 12);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(156, 71);
            btnUser.TabIndex = 3;
            btnUser.Text = "Users";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnProduct);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";

            panel1.Size = new Size(1344, 90);
            panel1.TabIndex = 4;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.Location = new Point(1148, 12);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(156, 71);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Orders";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Silver;
            panelMain.Location = new Point(2, 89);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1344, 582);
            panelMain.TabIndex = 5;
            panelMain.Paint += panelMain_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(2, 674);
            label1.Name = "label1";
            label1.Size = new Size(183, 38);
            label1.TabIndex = 6;
            label1.Text = "Quản Lý Kho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(1213, 674);
            label2.Name = "label2";
            label2.Size = new Size(123, 38);
            label2.TabIndex = 7;
            label2.Text = "Nhóm 3";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}