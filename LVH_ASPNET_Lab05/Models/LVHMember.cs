using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LVH_ASPNET_Lab05.Models
{
    public class LVHMember
    {
        [Required(ErrorMessage ="Hãy nhập mã số")]
        [DataType(DataType.Currency)]
        public int? Id { get; set; }
        [Required(ErrorMessage ="Hãy nhập tên đăng nhập")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Hãy nhập họ tên")]
        public string Fullname { get; set; }
        [Required(ErrorMessage ="Hãy nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage ="Hãy nhập số tuổi")]
        [Range(18, 50, ErrorMessage = "Tuổi từ 18 đến 50")]
        public int? Age { get; set; }
        [Required(ErrorMessage ="Hãy nhập địa chỉ email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z]{2,4}",ErrorMessage ="Email phải đúng định dạng")]
        public string Email { get; set; }
    }
}