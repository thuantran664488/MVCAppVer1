using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppVer1.Models;

namespace MVCAppVer1.Controllers
{
    public class ProductController : HomeController
    {
        // GET: Product/Phone
        public ActionResult Phone()
        {
            var iPhone = new Product() { Name = "IPhone X" };
            return View(iPhone);
        }

        public ActionResult Detail(string url, string id)
        {
            if (string.IsNullOrEmpty(id)) return null;

            var lst = Helper.GetListProducts();
            if (lst == null || lst.Count == 0) return null;

            var obj = lst.FirstOrDefault(p => p != null && p.Id.Equals(id) && p.metaTitle.Equals(url));
            if (obj == null) return null;
            return View(obj);
        }
    }
}