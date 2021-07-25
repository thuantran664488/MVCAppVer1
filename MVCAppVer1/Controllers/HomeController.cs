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
        /// FETCH DATE USING BUTTON VIEWMORE IN HOMEPAGE
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <returns></returns>
        public ActionResult fetchData(int PageIndex, Boolean isSearching, string keyword)
        {
            Webservice.ProductService.ProductDTOResponse getProducts;
            double minPrice = 0;
            double maxPrice = 10000000;
            if (!isSearching)
            {
                getProducts = Webservice.Helper.getProducts(PageSize, PageIndex);
            }
            else
            {
                getProducts = Webservice.Helper.searchProduct(PageSize, PageIndex, keyword, minPrice, maxPrice);
            }
            var remain = getProducts.Remain;

            var listProducts = getProducts.ListProducts;
            if (listProducts != null)
            {
                var JSON = Json(new
                {
                    remain = remain,
                    html = Helper.RenderViewToString(ControllerContext, "~/Views/Home/ListProduct.cshtml", getProducts, true)
                }); ;

                //return PartialView("ListProduct", totalProduct.Skip(PageSize * PageIndex).Take(PageSize));
                return JSON;
            }
            else
            {
                return null;
            }
        }

        public ActionResult Index(string search)
        {
            double minPrice = 0;
            double maxPrice = 10000000;
            var PageIndex = 0;
            var searchProducts = Webservice.Helper.searchProduct(PageSize, PageIndex, search, minPrice, maxPrice);
            //var listProducts = searchProduct.ListProducts;


            return View(searchProducts);
        }

        /// <summary>
        /// ROUTE TO THE HOME PAGE
        /// </summary>
        /// <returns></returns>
        //public ActionResult Index()
        //{

        //    //return View(totalProduct.Take(PageSize));
        //    var getProducts = Webservice.Helper.getProducts(PageSize, 0);
        //    var listProducts = getProducts.ListProducts;

        //    return View(listProducts);
        //}
    }
}