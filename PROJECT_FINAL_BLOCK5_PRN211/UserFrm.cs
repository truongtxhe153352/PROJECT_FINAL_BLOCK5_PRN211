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
    public partial class UserFrm : Form
    {
        QuanLyKhoContext context = new QuanLyKhoContext();
        public UserFrm()
        {
            InitializeComponent();
        }

        private void UserFrm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {

            var data = (from item in context.TbUsers
                        select new
                        {
                            item.Userid,
                            item.Username,
                            item.Fullname,
                            item.Password,
                            item.Phone
                        }).ToList();

            // nap du lieu

            dgUser.DataSource = data;
            txtUserID.DataBindings.Clear();
            txtUserID.DataBindings.Add("Text", data, "Userid");

            txtUserName.DataBindings.Clear();
            txtUserName.DataBindings.Add("Text", data, "Username");

            txtUserFullname.DataBindings.Clear();
            txtUserFullname.DataBindings.Add("Text", data, "Fullname");

            txtUserPass.DataBindings.Clear();
            txtUserPass.DataBindings.Add("Text", data, "Password");

            txtUserPhone.DataBindings.Clear();
            txtUserPhone.DataBindings.Add("Text", data, "Phone");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in (from item in context.TbUsers
                                      select new { item.Username }).ToList())
                    if (item.Username.Equals(txtUserName.Text))
                    {
                        MessageBox.Show("username trung!!!");
                        return;
                    }
                if (!Regex.IsMatch(txtUserPhone.Text, @"^[0][0-9]{9}$"))
                {
                    MessageBox.Show("Vui lòng nhập đủ 10 số và chỉ là số");
                    return;
                }
                //tao du lieu insert
                TbUser cate = new TbUser
                {
                    Username = txtUserName.Text,
                    Fullname = txtUserFullname.Text,
                    Password = txtUserPass.Text,
                    Phone = txtUserPhone.Text
                };

                //nap du lieu vao context
                context.TbUsers.Add(cate);
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
                var cate = context.TbUsers.SingleOrDefault(item => item.Userid == int.Parse(txtUserID.Text));
                if (!Regex.IsMatch(txtUserPhone.Text, @"^[0][0-9]{9}$"))
                {
                    MessageBox.Show("Vui lòng nhập đủ 10 số và chỉ là số");
                    return;
                }
                if (cate != null)
                {
                    cate.Username = txtUserName.Text;
                    cate.Fullname = txtUserFullname.Text;
                    cate.Password = txtUserPass.Text;
                    cate.Phone = txtUserPhone.Text;
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
                var cate = context.TbUsers.SingleOrDefault(item => item.Userid == int.Parse(txtUserID.Text));

                if (cate != null)
                {
                    //xoa
                    context.TbUsers.Remove(cate);
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

        private void txtUserPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!txtSearch.Text.Equals(""))
            {

                var data = (from item in context.TbUsers
                            where (item.Username.Contains(txtSearch.Text) || item.Fullname.Contains(txtSearch.Text))
                            select new { item.Userid, item.Username, item.Fullname, item.Password, item.Phone }).ToList();

                // nap du lieu

                dgUser.DataSource = data;
                txtUserID.DataBindings.Clear();
                txtUserID.DataBindings.Add("Text", data, "Userid");

                txtUserName.DataBindings.Clear();
                txtUserName.DataBindings.Add("Text", data, "Username");

                txtUserFullname.DataBindings.Clear();
                txtUserFullname.DataBindings.Add("Text", data, "Fullname");

                txtUserPass.DataBindings.Clear();
                txtUserPass.DataBindings.Add("Text", data, "Password");

                txtUserPhone.DataBindings.Clear();
                txtUserPhone.DataBindings.Add("Text", data, "Phone");
            }
            else
            {
                loadData();
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            MainForm mainForm = new MainForm(); // tạo một thể hiện mới của MainForm

            mainForm.Show(); // hiển thị
            this.Hide();
        }
    }


}
