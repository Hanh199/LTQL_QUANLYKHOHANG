using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL.Models
{ 
    [Table("THONGTINs")]
    public class THONGTIN
    {
        [Key]
        public String ThongtinID { get; set; }
        public String Tieude { get; set; }
        [AllowHtml]
        public String Noidung { get; set; }
    }
}