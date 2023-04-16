using System;
using System.Collections.Generic;

namespace QuanLyKho.Models
{
    public partial class TbUser
    {
        public int Userid { get; set; }
        public string? Username { get; set; }
        public string? Fullname { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
    }
}
