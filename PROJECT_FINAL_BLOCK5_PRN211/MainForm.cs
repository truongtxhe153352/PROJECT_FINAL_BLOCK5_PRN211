﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductFrm productFrm = new ProductFrm();
            productFrm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderFrm orderFrm = new OrderFrm();
            orderFrm.Show(); this.Hide();
        }
    }
}
