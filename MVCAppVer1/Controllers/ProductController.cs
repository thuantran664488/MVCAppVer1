using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppVer1.Models;

namespace MVCAppVer1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product/Phone
        public ActionResult Phone()
        {
            var iPhone = new Product() { Name = "IPhone X" };
            return View(iPhone);
        }

        // GET: Product/Detail
        public ActionResult detail(string id)
        {
            var product = new Product()
            {
                Id = id,
                Name = "Bàn Làm Việc Kết Hợp Kệ Sách Thông Minh",
                price = 48,
                url = "/Content/src/Image/ban_lam_viec.jpg"
            };
            return View(product);
        }
    }
}