using System;
using System.Collections.Generic;

namespace PROJECT_FINAL_BLOCK5_PRN211.Models
{
    public partial class TbProduct
    {
        public TbProduct()
        {
            TbOrders = new HashSet<TbOrder>();
        }

        public int Pid { get; set; }
        public string? Pname { get; set; }
        public int? Pqty { get; set; }
        public int? Pprice { get; set; }
        public string? Pdescription { get; set; }
        public int? Cateid { get; set; }

        public virtual TbCategory? Cate { get; set; }
        public virtual ICollection<TbOrder> TbOrders { get; set; }
    }
}
