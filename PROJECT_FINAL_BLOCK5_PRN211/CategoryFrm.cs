using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_FINAL_BLOCK5_PRN211.Models;

namespace QuanLyKho
{
    public partial class CategoryFrm : Form
    {

        QuanLyKhoContext context = new QuanLyKhoContext();
        public CategoryFrm()
        {
            InitializeComponent();
        }

        private void CategoryFrm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {

            var data = (from item in context.TbCategories
                        select new { item.Catid, item.Catname }).ToList();

            // nap du lieu

            dgCategory.DataSource = data;
            txtCateID.DataBindings.Clear();
            txtCateID.DataBindings.Add("Text", data, "Catid");

            txtCateName.DataBindings.Clear();
            txtCateName.DataBindings.Add("Text", data, "Catname");
        }

        private void dgCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in (from item in context.TbCategories
                                      select new { item.Catname }).ToList())
                    if (item.Catname.Equals(txtCateName.Text))
                    {
                        MessageBox.Show("Cate Name trung!!!");
                        return;
                    }
                //tao du lieu insert
                TbCategory cate = new TbCategory { Catname = txtCateName.Text };

                //nap du lieu vao context
                context.TbCategories.Add(cate);
                int count = context.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show("Insert succes");
                    loadData();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert error:" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                //tim du lieu can update
                var cate = context.TbCategories.SingleOrDefault(item => item.Catid == int.Parse(txtCateID.Text));

                if (cate != null)
                {
                    cate.Catname = txtCateName.Text;
                    int count = context.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("update succes");
                        loadData();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("update error:" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //kiem tra cate id ton tai tron product ko
                var listProduct = from item in context.TbProducts
                                  where item.Cateid == int.Parse(txtCateID.Text)
                                  select item;


                //tim du lieu can delete
                var cate = context.TbCategories.SingleOrDefault(item => item.Catid == int.Parse(txtCateID.Text));

                if (cate != null)
                {
                    //xoa
                    context.TbCategories.Remove(cate);
                    int count = context.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Delete succes");
                        loadData();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("delete error:" + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!txtSearch.Text.Equals(""))
            {

                // nap du lieu
                var data = (from item in context.TbCategories
                            where (item.Catname.Contains(txtSearch.Text))
                            select new { item.Catid, item.Catname }).ToList();

                dgCategory.DataSource = data;
                txtCateID.DataBindings.Clear();
                txtCateID.DataBindings.Add("Text", data, "Catid");

                txtCateName.DataBindings.Clear();
                txtCateName.DataBindings.Add("Text", data, "Catname");
            }
            else
            {
                loadData();
            }
        }
    }
}
