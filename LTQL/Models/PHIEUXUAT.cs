using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("PHIEUXUATs")]
    public class PHIEUXUAT
    {
        [Key]
        [Required, MaxLength(10)]
        public string MaPX { get; set; }
        public string MaMH { get; set; }
        public DateTime Ngayxuat { get; set; }
        public string Nhanvien { get; set; }
        public virtual CTPX CTPXs { get; set; }
    }
}