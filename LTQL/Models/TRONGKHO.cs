using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("TRONGKHOs")]
    public class TRONGKHO
    {
        [Key]
        public int STT { get; set; }
        [Required, MaxLength(50)]
        public string Tenkho { get; set; }
        [Required, MaxLength(50)]
        public string TenMH { get; set; }
        public int Soluong { get; set; }
        public string DVT { get; set; }
        public float Dongia { get; set; }
        public virtual ICollection<MATHANG> MATHANGs { get; set; }
        public virtual ICollection<KHOHANG> KHOHANGs { get; set; }

    }
}