using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppVer1.Models;
using System.IO;
using Webservice;
using Webservice.ProductService;

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
        public ActionResult fetchData(int PageIndex, bool isSearching, string keyword)
        {
            ProductDTOResponse getProducts;
            double minPrice = 0;
            double maxPrice = 10000000;
            if (!isSearching)
            {
                getProducts = Service.Instance.getProducts(PageSize, PageIndex);
            }
            else
            {
                getProducts = Service.Instance.searchProduct(PageSize, PageIndex, keyword, minPrice, maxPrice);
            }

            var listProducts = getProducts.ListProducts;
            if (listProducts != null)
            {
                var JSON = Json(new
                {
                    remain = getProducts.Remain,
                    html = Helper.RenderViewToString(ControllerContext, "~/Views/Home/ListProduct.cshtml", getProducts, true)
                }); ;
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
            var searchProducts = Service.Instance.searchProduct(PageSize, PageIndex, search, minPrice, maxPrice);

            return View(searchProducts);
        }
    }
}