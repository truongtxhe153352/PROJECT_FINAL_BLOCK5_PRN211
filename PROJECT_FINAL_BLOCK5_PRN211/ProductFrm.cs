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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJECT_FINAL_BLOCK5_PRN211
{
    public partial class ProductFrm : Form
    {
        public ProductFrm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show("hien thi category " + cbCategory.SelectedValue);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            using (var context = new QuanLyKhoContext())
            {
                var query = (from p in context.TbProducts
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
                             });

                dtgProduct.DataSource = query.ToList();

                var queryCate = (from c in context.TbCategories select c);
                cbCategory.DataSource = queryCate.ToList();
                cbCategory.DisplayMember = "Catname";
                cbCategory.ValueMember = "Catid";
            }
        }

        private void dtgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgProduct.Rows.Count) // kiểm tra chỉ số hàng
            {
                txtProductId.Text = dtgProduct.Rows[e.RowIndex].Cells["Pid"].Value.ToString();
                txtProductName.Text = dtgProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = dtgProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dtgProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDescription.Text = dtgProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbCategory.Text = dtgProduct.Rows[e.RowIndex].Cells["Catname"].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int cate = Convert.ToInt32(cbCategory.SelectedValue);
            using var context = new QuanLyKhoContext();

            TbProduct tbProduct = new TbProduct();

            tbProduct.Pname = txtProductName.Text;
            tbProduct.Pprice = Convert.ToInt32(txtPrice.Text);
            tbProduct.Pqty = Convert.ToInt32(txtQuantity.Text);
            tbProduct.Pdescription = txtDescription.Text;
            tbProduct.Cateid = cate;

            context.TbProducts.Add(tbProduct);
            context.SaveChanges();
            MessageBox.Show("Add successfulluly!!!");

            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int cate = Convert.ToInt32(cbCategory.SelectedValue);
            using (var context = new QuanLyKhoContext())
            {
                TbProduct tbProduct = context.TbProducts.Find(dtgProduct
                    .Rows[dtgProduct.CurrentRow.Index].Cells[0].Value);

                tbProduct.Pqty = Convert.ToInt32(txtQuantity.Text);
                tbProduct.Pname = txtProductName.Text.Trim();
                tbProduct.Pprice = Convert.ToInt32(txtPrice.Text);
                tbProduct.Pdescription = txtDescription.Text.Trim();
                tbProduct.Cateid = cate;

                context.TbProducts.Update(tbProduct);
                context.SaveChanges();
                MessageBox.Show("Edit successful!!!");
            }
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new QuanLyKhoContext())
            {
                TbProduct product = context.TbProducts.Find(dtgProduct.Rows[dtgProduct.CurrentRow.Index].Cells[0].Value);

                context.TbProducts.Remove(product);
                context.SaveChanges();
                MessageBox.Show("Edit successful!!!");
            }
            loadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtProductName.Clear();
            txtProductId.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            cbCategory.SelectedItem = null;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (var context = new QuanLyKhoContext())
            {
                var data = (from item in context.TbProducts
                            join item1 in context.TbCategories on item.Cateid equals item1.Catid
                            where (item.Pname.Contains(txtFilter.Text) || item1.Catname.Contains(txtFilter.Text))
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
}
