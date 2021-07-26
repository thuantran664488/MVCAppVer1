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

            var getAll = Webservice.Helper.getProducts(20, 0);
            var lst = getAll.ListProducts;
            if (lst == null || getAll.Total == 0) return null;

            var obj = lst.FirstOrDefault(p => p != null && p.Id.Equals(id) && p.Url.Equals(url));
            if (obj == null) return null;

            return View(obj);
        }
    }
} 