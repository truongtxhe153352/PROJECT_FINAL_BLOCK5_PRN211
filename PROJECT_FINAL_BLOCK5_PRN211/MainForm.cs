using PROJECT_FINAL_BLOCK5_PRN211;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductFrm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private MessageBoxDefaultButton button;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

            openChildForm(new CustomerFrm());

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryFrm());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            openChildForm(new UserFrm());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderFrm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
