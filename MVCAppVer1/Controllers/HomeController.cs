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
        public ActionResult fetchData(int PageIndex)
        {
            ProductDTOResponse getProducts;
            getProducts = Service.Instance.getProducts(PageSize, PageIndex);

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

        public ActionResult Index()
        {

            var PageIndex = 0;
            var searchProducts = Service.Instance.getProducts(PageSize, PageIndex);
            if (searchProducts != null)
            {
                return View(searchProducts);
            }
            else return null;

        }
    }
}