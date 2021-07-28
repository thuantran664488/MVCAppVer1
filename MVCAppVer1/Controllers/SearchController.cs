using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webservice;

namespace MVCAppVer1.Controllers
{
    public class SearchController : Controller
    {

        private const int PageSize = 4;
        // GET: Search
        public ActionResult SearchByName(string search, double minPrice = 0, double maxPrice = 1000000000)
        {

            var PageIndex = 0;
            var searchProducts = Service.Instance.searchProduct(PageSize, PageIndex, search, minPrice, maxPrice);

            return View("~/Views/Search/Search.cshtml", searchProducts);
        }

        public ActionResult Filter(int PageIndex, string keyword, double minPrice, double maxPrice)
        {

            var searchProducts = Service.Instance.searchProduct(PageSize, PageIndex, keyword, minPrice, maxPrice);
            //var searchProducts = Service.Instance.searchProduct(PageSize, PageIndex, keyword, 0, 100);


            var listProducts = searchProducts.ListProducts;
            if (listProducts != null)
            {
                var JSON = Json(new
                {
                    total = searchProducts.Total,
                    remain = searchProducts.Remain,
                    html = Helper.RenderViewToString(ControllerContext, "~/Views/Home/ListProduct.cshtml", searchProducts, true)
                });
                return JSON;
            }
            else
            {
                return null;
            }
        }
    }
}