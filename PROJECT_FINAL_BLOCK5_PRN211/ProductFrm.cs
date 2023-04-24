using PROJECT_FINAL_BLOCK5_PRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
                                 ProductName = p.Pname,
                                 Quantity = p.Pqty,
                                 Price = p.Pprice,
                                 Description = p.Pdescription,
                                 CategoryName = c.Catname
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
                numericQuantity.Value = Convert.ToInt32(dtgProduct.Rows[e.RowIndex].Cells[2].Value);
                txtPrice.Text = dtgProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDescription.Text = dtgProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbCategory.Text = dtgProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi sau khi Add không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Thực hiện hành động khi người dùng chọn Yes
                int cate = Convert.ToInt32(cbCategory.SelectedValue);
                using var context = new QuanLyKhoContext();
                {
                    bool isDuplicateName = (from p in context.TbProducts
                                            where (p.Pname == txtProductName.Text)
                                            select p).Any();

                    TbProduct tbProduct = new TbProduct();

                    if (!string.IsNullOrWhiteSpace(txtProductName.Text) && !isDuplicateName)
                    {
                        tbProduct.Pname = txtProductName.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid name");
                        return;
                    }

                    if (!Regex.IsMatch(txtPrice.Text, @"^[0-9]+$"))
                    {
                        MessageBox.Show("Please enter a valid Price!!");
                        return;
                    }
                    else
                    {
                        tbProduct.Pprice = Convert.ToInt32(txtPrice.Text);
                    }

                    if (!Regex.IsMatch(numericQuantity.Text, @"^[1-9]+$"))
                    {
                        MessageBox.Show("Please enter a valid Quantity !!");
                        return;
                    }
                    else
                    {
                        tbProduct.Pqty = Convert.ToInt32(numericQuantity.Value);
                    }

                    if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                    {
                        tbProduct.Pdescription = txtDescription.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Description");
                        return;
                    }
                    if (cate != null)
                    {
                        tbProduct.Cateid = cate;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Catefory");
                        return;
                    }

                    context.TbProducts.Add(tbProduct);
                    context.SaveChanges();
                    MessageBox.Show("Add successfulluly!!!");

                    loadData();
                }
            }
            else
            {
                // Thực hiện hành động khi người dùng chọn No
                return;
            }




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int cate = Convert.ToInt32(cbCategory.SelectedValue);
            using (var context = new QuanLyKhoContext())
            {
                TbProduct tbProduct = context.TbProducts.Find(dtgProduct
                    .Rows[dtgProduct.CurrentRow.Index].Cells[0].Value);

                tbProduct.Pqty = Convert.ToInt32(numericQuantity.Value);
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
                DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện hành động khi người dùng chọn Yes
                    TbProduct product = context.TbProducts.Find(dtgProduct.Rows[dtgProduct.CurrentRow.Index].Cells[0].Value);

                    if (product != null)
                    {
                        context.TbProducts.Remove(product);
                        context.SaveChanges();
                        MessageBox.Show("Delete successful!!!");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Có người đang Order sản phẩm này, không được DELETE!!!");
                    }
                }
                else
                {
                    // Thực hiện hành động khi người dùng chọn No
                    return;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtProductName.Clear();
            txtProductId.Clear();
            numericQuantity.Value = 0;
            txtPrice.Clear();
            cbCategory.SelectedItem = null;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (var context = new QuanLyKhoContext())
            {
                if (!string.IsNullOrEmpty(txtFilter.Text))
                {
                    var data = (from item in context.TbProducts
                                join item1 in context.TbCategories on item.Cateid equals item1.Catid
                                where (item.Pname.Contains(txtFilter.Text) && item1.Catname.Contains(cbCategory.Text)
                               )
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
                    loadData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
