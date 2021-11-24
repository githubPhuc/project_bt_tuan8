using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_bt_tuan8.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult qlthanhvien()
        {
            return View();
        }
        public IActionResult qlBaiViet()
        {
            return View();
        }
        public IActionResult quanlicauhinhwep()
        {
            return View();
        }
        public IActionResult quanlidiendan()
        {
            return View();
        }

    }
}
