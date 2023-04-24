using PROJECT_FINAL_BLOCK5_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_FINAL_BLOCK5_PRN211
{
    public partial class OrderAdd : Form
    {
        public OrderAdd()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {
            using (var context = new QuanLyKhoContext())
            {
                var customer = (from c in context.TbCustomers select c).ToList();
                var product = (from p in context.TbProducts
                               join c in context.TbCategories
                         on p.Cateid equals c.Catid
                               select new
                               {
                                   p.Pid,
                                   p.Pname,
                                   p.Pqty,
                                   p.Pprice,
                                   p.Pdescription,
                                   c.Catname
                               }).ToList();

                dtgCustomer.DataSource = customer;
                dtgProduct.DataSource = product;
            }
        }

        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgProduct.Rows.Count) // kiểm tra chỉ số hàng
            {
                txtCustomerID.Text = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCustomerName.Text = dtgCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgProduct.Rows.Count) // kiểm tra chỉ số hàng
            {
                txtProductID.Text = dtgProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProductName.Text = dtgProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                //   numericQuantity.Value = Convert.ToInt32(dtgProduct.Rows[e.RowIndex].Cells[2].Value);
                txtPrice.Text = dtgProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (int.Parse(txtPrice.Text) * numericQuantity.Value).ToString();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            using (var context = new QuanLyKhoContext())
            {
                if (!string.IsNullOrEmpty(txtSearchCustomer.Text))
                {
                    var customer = (from c in context.TbCustomers
                                    where c.Cname.Contains(txtSearchCustomer.Text)
                                    || c.Cphone.Contains(txtSearchCustomer.Text)
                                    select c).ToList();

                    dtgCustomer.DataSource = customer;
                }
                else
                {
                    var customer = (from c in context.TbCustomers
                                    select c).ToList();

                    dtgCustomer.DataSource = customer;
                }

            }
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            using (var context = new QuanLyKhoContext())
            {
                if (!string.IsNullOrEmpty(txtSearchProduct.Text))
                {
                    var data = (from item in context.TbProducts
                                join item1 in context.TbCategories on item.Cateid equals item1.Catid
                                where (item.Pname.Contains(txtSearchProduct.Text))
                                select new
                                {
                                    item.Pid,
                                    item.Pname,
                                    item.Pqty,
                                    item.Pprice,
                                    item.Pdescription,
                                    item1.Catname
                                }).ToList();

                    dtgProduct.DataSource = data;
                }
                else
                {
                    var data = (from item in context.TbProducts
                                join item1 in context.TbCategories on item.Cateid equals item1.Catid
                                select new
                                {
                                    item.Pid,
                                    item.Pname,
                                    item.Pqty,
                                    item.Pprice,
                                    item.Pdescription,
                                    item1.Catname
                                }).ToList();

                    dtgProduct.DataSource = data;
                }

            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (var context = new QuanLyKhoContext())
            {
                //  DialogResult result = MessageBox.Show("Bạn có muốn lưu cập nhật không?", "Thông báo", MessageBoxButtons.YesNo);
                //bool queryCheck = (from o in context.TbOrders
                //              join p in context.TbProducts
                //              on o.Pid equals p.Pid
                //              join c in context.TbCustomers 
                //              on o.Cid equals c.Cid
                //              select o
                //              ).Any();

                TbOrder tbOrder = new TbOrder();
                tbOrder.Odate = dpkDateOrder.Value;
                tbOrder.Pid = Convert.ToInt32(txtProductID.Text);
                tbOrder.Cid = Convert.ToInt32(txtCustomerID.Text);
                tbOrder.Qty = Convert.ToInt32(numericQuantity.Value);
                tbOrder.Price = Convert.ToInt32(txtPrice.Text);

                MessageBox.Show("Are your sure Order???");

                context.TbOrders.Add(tbOrder);
                context.SaveChanges();
                MessageBox.Show("Order successfull!!!!!!");
                OrderFrm orderFrm = new OrderFrm();
                orderFrm.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OrderFrm orderFrm = new OrderFrm();
            orderFrm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new QuanLyKhoContext())
            {
                //TbOrder tbOrder = context.TbOrders.Find(
                //    dt);
                //tbOrder.Odate = dpkDateOrder.Value;
                //tbOrder.Pid = Convert.ToInt32(txtProductID.Text);
                //tbOrder.Cid = Convert.ToInt32(txtCustomerID.Text);
                //tbOrder.Qty = Convert.ToInt32(numericQuantity.Value);
                //tbOrder.Price = Convert.ToInt32(txtPrice.Text);

                //MessageBox.Show("Are your sure Order???");

                //context.TbOrders.Add(tbOrder);
                //context.SaveChanges();
                //MessageBox.Show("Order successfull!!!!!!");
                //OrderFrm orderFrm = new OrderFrm();
                //orderFrm.Show();
                //this.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtProductID.Clear();
            txtProductName.Clear();
            dpkDateOrder.Value = DateTime.Now;
            txtPrice.Clear();
            numericQuantity.Value = 0;
            txtTotal.Clear();
            txtSearchCustomer.Clear();
            txtSearchProduct.Clear();
        }
    }
}
