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
        /// <summary>
        /// ROUTE THE DETAIL PAGE
        /// </summary>
        /// <param name="url"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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