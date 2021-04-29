using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("CTPXs")]
    public class CTPX
    {
        [Key]
        public int STTPX { get; set; }
        [Required, MaxLength(10)]
        public string MaPX { get; set; }
        [Required, MaxLength(50)]
        public string TenPX { get; set; }
        [Required, MaxLength(50)]
        public string TenMH { get; set; }
        [Required, MaxLength(50)]
        public string TenNCC { get; set; }
        public int Soluong { get; set; }
        public float Dongia { get; set; }
        public virtual ICollection<MATHANG> MATHANGs { get; set; }
        public virtual ICollection<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
        public virtual ICollection<PHIEUXUAT> PHIEUXUATs { get; set; }
   
    }
}