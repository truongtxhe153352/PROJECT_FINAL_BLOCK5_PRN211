using System;
using System.Collections.Generic;

namespace QuanLyKho.Models
{
    public partial class TbCategory
    {
        public TbCategory()
        {
            TbProducts = new HashSet<TbProduct>();
        }

        public int Catid { get; set; }
        public string? Catname { get; set; }

        public virtual ICollection<TbProduct> TbProducts { get; set; }
    }
}
