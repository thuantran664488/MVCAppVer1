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
        //GET: product/{url}-{id}
        public ActionResult viewDetail (string url, string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(url)) return null;

            var lst = GetListProducts();
            if (lst == null || lst.Count == 0) return null;

            var obj = lst.FirstOrDefault(p => p != null && p.Id.Equals(id));
            if (obj == null) return null;

            return View("Detail",obj);
        }

        // GET: Product/detail ->  Redirecto to Home page
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}