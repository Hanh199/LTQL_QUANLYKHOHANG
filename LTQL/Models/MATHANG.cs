using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("MATHANGs")]
    public class MATHANG
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaMH { get; set; }
        [Required, MaxLength(50)]
        public string TenMH { get; set; }
        [Required, MaxLength(10)]
        public string Makho { get; set; }
        public virtual TRONGKHO TRONGKHOs { get; set; }
        public virtual CTPN CTPNs { get; set; }
        public virtual CTPX CTPXs { get; set; }

    }
}