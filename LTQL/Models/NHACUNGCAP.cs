using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("NHACUNGCAPs")]
    public class NHACUNGCAP
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaNCC { get; set; }
        [Required, MaxLength(50)]
        public string TenNCC { get; set; }
        [Required, MaxLength(100)]
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public virtual CTPX CTPXs { get; set; }
        public virtual CTPN CTPNs { get; set; }
    }
}