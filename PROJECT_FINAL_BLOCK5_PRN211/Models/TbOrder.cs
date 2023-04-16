using System;
using System.Collections.Generic;

namespace QuanLyKho.Models
{
    public partial class TbOrder
    {
        public int Orderid { get; set; }
        public DateTime? Odate { get; set; }
        public int? Pid { get; set; }
        public int? Cid { get; set; }
        public int? Qty { get; set; }
        public int? Price { get; set; }

        public virtual TbCustomer? CidNavigation { get; set; }
        public virtual TbProduct? PidNavigation { get; set; }
    }
}
