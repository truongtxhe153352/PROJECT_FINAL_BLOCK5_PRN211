﻿using PROJECT_FINAL_BLOCK5_PRN211.Models;
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
    public partial class OrderFrm : Form
    {
        public OrderFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void OrderFrm_Load(object sender, EventArgs e)
        {
            // this is commen demo
            loadData();
        }

        private void loadData()
        {
            using (var context = new QuanLyKhoContext())
            {
                var query = (from o in context.TbOrders
                             join p in context.TbProducts
                             on o.Pid equals p.Pid
                             join c in context.TbCustomers on o.Cid equals c.Cid
                             select new
                             {
                                 o.Orderid,
                                 o.Odate,
                                 Customer = c.Cname,
                                 Product = p.Pname,
                                 Quantity = o.Qty,
                                 o.Price
                             }
                             ).ToList();
                dtgOrder.DataSource = query;
            }
        }

        private void dtgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgOrder.Rows.Count) // kiểm tra chỉ số hàng
            {
                txtOrderId.Text = dtgOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtOrderQuantity.Text = dtgOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var context = new QuanLyKhoContext())
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    var query = (from o in context.TbOrders
                                 join p in context.TbProducts
                     on o.Pid equals p.Pid
                                 join c in context.TbCustomers on o.Cid equals c.Cid
                                 where p.Pname.Contains(txtSearch.Text) 
                                 || c.Cname.Contains(txtSearch.Text)
                                 || c.Cphone.Contains(txtSearch.Text)
                                 select new
                                 {
                                     o.Orderid,
                                     o.Odate,
                                     Customer = c.Cname,
                                     Product = p.Pname,
                                     Quantity = o.Qty,
                                     o.Price
                                 }
                             ).ToList();
                    dtgOrder.DataSource = query;
                }
                else
                {
                    loadData();
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderAdd orderAdd = new OrderAdd();
            orderAdd.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(var context = new QuanLyKhoContext())
            {
               TbOrder o = context.TbOrders.Find(dtgOrder.Rows[dtgOrder.CurrentRow.Index].Cells[0].Value);
                if (o != null)
                {
                    MessageBox.Show("Are you want to Delete" );
                    context.TbOrders.Remove(o);
                    context.SaveChanges();
                    MessageBox.Show("Delete succeess!!!");
                    loadData();
                }

            }
        }
    }
}
