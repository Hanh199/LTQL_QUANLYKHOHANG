using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("CTPNs")]
    public class CTPN
    {
        [Key]
        public int STTPN { get; set; }
        [Required, MaxLength(10)]
        public string MaPN { get; set; }
        [Required, MaxLength(50)]
        public string TenPN { get; set; }
        [Required, MaxLength(50)]
        public string TenMH { get; set; }
        [Required, MaxLength(50)]
        public string TenKH { get; set; }
        public int Soluong  { get; set; }
        public float Dongia  { get; set; }
        public virtual ICollection<MATHANG> MATHANGs { get; set; }
        public virtual ICollection<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
        
    }
}