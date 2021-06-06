using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLNS.Models
{
    [Table ("NHANVIENs")]
    public class NHANVIEN
    {

        [Key]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string MaCV { get; set; }
        public virtual ICollection <CHUCVU> CHUCVUs { get; set; }



    }
}