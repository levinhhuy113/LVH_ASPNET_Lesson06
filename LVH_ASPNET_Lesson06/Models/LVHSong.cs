using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LVH_ASPNET_Lesson06.Models
{
    public class LVHSong
    {
        public int  Id { get; set; }
        [DisplayName("Tiêu đề")]
        [Required(ErrorMessage ="LVH: Hãy nhập tiêu đề")]
        
        public string lvhTitle { get; set; }
        [DisplayName("Tác giả")]
        [Required(ErrorMessage ="LVH: Hãy nhập tác giả")]
        public string lvhAuthor { get; set; }
        [DisplayName("Nghệ sĩ")]
        [Required(ErrorMessage ="LVH: Hãy nhập nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="LVH: Độ dài phải trong khoảng[2-50]")]
        public string lvhArtist { get; set; }
        [DisplayName("Năm xuất bản")]
        [Required(ErrorMessage = "LVH: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="LVH: Năm xuất bản phỉa là số có 4 kí tự số")]
        [Range(1900,2020,ErrorMessage ="LVH: Năm xuất bản trong khoảng 1900-2020")]
        public int lvhYearRelease { get; set; }
        
    }
}