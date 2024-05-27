using LVH_ASPNET_Lesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVH_ASPNET_Lesson06.Controllers
{
    public class LVHSongController : Controller
    {
        private static List<LVHSong> lvhSongs = new List<LVHSong>()
        {
            new LVHSong{Id=100,lvhTitle="Lê Vinh Huy",lvhAuthor="K22CNT1",lvhArtist="Huy",lvhYearRelease=2024}
        };
        // GET: LVHSong
        public ActionResult Index()
        {
            return View(lvhSongs);
        }
        public ActionResult lvhCreate()
        {
            var lvhSong = new LVHSong();
            return View(lvhSong);
        }
        [HttpPost]
        public ActionResult LVHCreate(LVHSong lvhSong)
        {
            if(!ModelState.IsValid) // nếu có lỗi xảy ra
            {
                return View(lvhSong);
            }

            //Nếu dữ liệu đúng -> lưu vào danh sách bài hát
            lvhSongs.Add(lvhSong);
            return RedirectToAction("Index");

        }
    }
}