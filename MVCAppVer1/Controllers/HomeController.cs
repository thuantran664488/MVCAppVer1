using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppVer1.Models;
using System.IO;

namespace MVCAppVer1.Controllers
{
    public class HomeController : Controller
    {
        private const int PageSize = 5;



        public ActionResult Index()
        {
            var totalProduct = Helper.GetListProducts();

            return View(totalProduct.Take(PageSize));
        }

        public ActionResult fetchData(int PageIndex)
        {
            var totalProduct = Helper.GetListProducts();
            var products = totalProduct.Skip(PageSize * PageIndex).Take(PageSize);
            var remain = totalProduct.Count - PageSize * PageIndex - PageSize;
            if (remain < 0) remain = 0;

            var JSON = Json(new
            {
                remain = remain,
                html = Helper.RenderViewToString(ControllerContext, "~/Views/Home/ListProduct.cshtml", products, true)
            });

            //return PartialView("ListProduct", totalProduct.Skip(PageSize * PageIndex).Take(PageSize));
            return JSON;

        }
    }
}