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
using PROJECT_FINAL_BLOCK5_PRN211.Models;

namespace QuanLyKho
{
    public partial class CustomerFrm : Form

    {
        QuanLyKhoContext context = new QuanLyKhoContext();
        public CustomerFrm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private bool IsPhoneNumberExists(string phone)
        {
            return context.TbCustomers.Any(c => c.Cphone == phone);
        }
        private void loadData()
        {

            var data = (from item in context.TbCustomers
                        select new { item.Cid, item.Cname, item.Cphone }).ToList();

            // nap du lieu

            dgCustomer.DataSource = data;
            txtCustomerID.DataBindings.Clear();
            txtCustomerID.DataBindings.Add("Text", data, "Cid");

            txtCustomerName.DataBindings.Clear();
            txtCustomerName.DataBindings.Add("Text", data, "Cname");

            txtCustomerPhone.DataBindings.Clear();
            txtCustomerPhone.DataBindings.Add("Text", data, "Cphone");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //tao du lieu insert
                TbCustomer cate = new TbCustomer { Cname = txtCustomerName.Text, Cphone = txtCustomerPhone.Text };
                if (!Regex.IsMatch(txtCustomerPhone.Text, @"^[0][0-9]{9}$"))
                {
                    MessageBox.Show("Vui lòng nhập đủ 10 số và chỉ là số");
                    return;
                }
                // Check sự tồn tại của số điện thoại
                if (IsPhoneNumberExists(txtCustomerPhone.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong cơ sở dữ liệu.");
                    return;
                }
                //nap du lieu vao context
                context.TbCustomers.Add(cate);
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
                var cate = context.TbCustomers.SingleOrDefault(item => item.Cid == int.Parse(txtCustomerID.Text));
                if (!Regex.IsMatch(txtCustomerPhone.Text, @"^[0][0-9]{9}$"))
                {
                    MessageBox.Show("Vui lòng nhập đủ 10 số và chỉ là số");
                    return;
                }
                if (IsPhoneNumberExists(txtCustomerPhone.Text) && cate.Cphone != txtCustomerPhone.Text)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại !");
                    return;
                }

                if (cate != null)
                {
                    cate.Cname = txtCustomerName.Text;
                    cate.Cphone = txtCustomerPhone.Text;
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

                //tim du lieu can delete
                var cate = context.TbCustomers.SingleOrDefault(item => item.Cid == int.Parse(txtCustomerID.Text));

                if (cate != null)
                {
                    //xoa
                    context.TbCustomers.Remove(cate);
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

                var data = (from item in context.TbCustomers
                            where (item.Cname.Contains(txtSearch.Text) || item.Cphone.Contains(txtSearch.Text))
                            select new { item.Cid, item.Cname, item.Cphone }).ToList();
                // nap du lieu


                dgCustomer.DataSource = data;
                txtCustomerID.DataBindings.Clear();
                txtCustomerID.DataBindings.Add("Text", data, "Cid");

                txtCustomerName.DataBindings.Clear();
                txtCustomerName.DataBindings.Add("Text", data, "Cname");

                txtCustomerPhone.DataBindings.Clear();
                txtCustomerPhone.DataBindings.Add("Text", data, "Cphone");
            }
            else
            {
                loadData();
            }

        }

        private void lbSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCustomerID_Click(object sender, EventArgs e)
        {

        }
    }
}
