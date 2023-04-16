using System;
using System.Collections.Generic;

namespace QuanLyKho.Models
{
    public partial class TbCustomer
    {
        public TbCustomer()
        {
            TbOrders = new HashSet<TbOrder>();
        }

        public int Cid { get; set; }
        public string? Cname { get; set; }
        public string? Cphone { get; set; }

        public virtual ICollection<TbOrder> TbOrders { get; set; }
    }
}
