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
    }
}