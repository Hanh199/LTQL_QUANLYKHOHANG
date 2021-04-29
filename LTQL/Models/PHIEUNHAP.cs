using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("PHIEUNHAPs")]
    public class PHIEUNHAP
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaPN { get; set; }
        public string MaMH { get; set; }
        public DateTime Ngaynhap { get; set; }
        public string Nhanvien { get; set; }
        public virtual CTPN CTPNs { get; set; }
    }
}