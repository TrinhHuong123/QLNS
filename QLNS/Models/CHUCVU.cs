using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLNS.Models
{
    [Table("CHUCVUs")]
    public class CHUCVU
    {
        [Key]
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public string MaNV { get; set; }

        public virtual NHANVIEN NHANVIENs { get; set; }
}
}