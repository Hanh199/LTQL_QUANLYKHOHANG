using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("KHACHHANGs")]
    public class KHACHHANG
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaKH {get;set;}
        [Required, MaxLength(50)]
        public string TenKH {get;set;}
        [Required, MaxLength(100)]
        public string Diachi {get;set;}
        public int SĐT {get;set;}
        public virtual CTPX CTPXs { get; set; }

    }
}