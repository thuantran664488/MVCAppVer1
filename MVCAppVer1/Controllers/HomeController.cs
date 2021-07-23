using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppVer1.Models;
using System.IO;
using Webservice;

namespace MVCAppVer1.Controllers
{
    public class HomeController : Controller
    {
        private const int PageSize = 5;


        /// <summary>
        /// ROUTE TO THE HOME PAGE
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            //return View(totalProduct.Take(PageSize));
            var getProducts = Webservice.Helper.getProducts(PageSize, 0);
            var listProducts = getProducts.ListProducts;

            return View(listProducts);
        }

        /// <summary>
        /// FETCH DATE USING BUTTON VIEWMORE IN HOMEPAGE
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <returns></returns>
        public ActionResult fetchData(int PageIndex)
        {
            var getProducts = Webservice.Helper.getProducts(PageSize, PageIndex);
            var listProducts = getProducts.ListProducts;
            var remain = getProducts.Remain;

            var JSON = Json(new
            {
                remain = remain,
                html = Helper.RenderViewToString(ControllerContext, "~/Views/Home/ListProduct.cshtml", listProducts, true)
            });

            //return PartialView("ListProduct", totalProduct.Skip(PageSize * PageIndex).Take(PageSize));
            return JSON;

        }
    }
}