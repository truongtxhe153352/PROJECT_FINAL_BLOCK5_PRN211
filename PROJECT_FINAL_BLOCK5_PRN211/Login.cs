using PROJECT_FINAL_BLOCK5_PRN211;
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

namespace QuanLyKho
{
    public partial class Login : Form
    {
        QuanLyKhoContext context = new QuanLyKhoContext();
        public Login()
        {
            InitializeComponent();
        }

        private void CbPass_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBoxPass.Checked == false)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int count = 0;
            var data = (from item in context.TbUsers
                        select new { item.Userid, item.Username, item.Fullname, item.Password, item.Phone }).ToList();
            foreach(var item in data)
            {
                if (txtUsername.Text.Equals(item.Username) && txtPassword.Text.Equals(item.Password))
                {
                    MainForm m = new MainForm();
                    MessageBox.Show("Welcome " + item.Fullname);
                    m.Show();
                    this.Hide();
                    count++;
                }
            }
            if(count ==0)
                MessageBox.Show("error");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
