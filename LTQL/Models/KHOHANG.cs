using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("KHOHANGs")]
    public class KHOHANG
    {
        [Key]
        [Required, MaxLength(10)]
        public string Makho { get; set; }
        [Required, MaxLength(50)]
        public string Tenkho { get; set; }
        [Required, MaxLength(100)]
        public string Diachi { get; set; }
        [Required, MaxLength(50)]
        public string Thukho { get; set; }
        public virtual TRONGKHO TRONGKHOs { get; set; }
    }
}