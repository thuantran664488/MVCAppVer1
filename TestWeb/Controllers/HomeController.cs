using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var productSvc = new Webservice.ProductService.ProductSvc();

            return Content(Webservice.Helper.getProducts(5, 0).ListProducts[0].Id);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}