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
        public ActionResult Detail(string url, string id)
        {
            long idFromUrl;
            int validId;
            try
            {
                // Max Int 32 = 2,147,483,647 - Lenght = 10
                if (id.Length > 10)
                {
                    return View("~/Views/Home/Index.cshtml");
                }
                else
                {
                    idFromUrl = Int64.Parse(id);
                    if (idFromUrl > Int32.MaxValue || idFromUrl < Int32.MinValue)
                    {
                        return View("~/Views/Home/Index.cshtml");
                    }
                    else
                    {
                        validId = Int32.Parse(idFromUrl.ToString());
                    }
                }

            }
            catch (FormatException)
            {
                //Unable to parse id;
                return View("~/Views/Home/Index.cshtml");
            }

            var obj = Webservice.Helper.getProductById(validId);
            if (obj == null) return View("~/Views/Home/Index.cshtml");
            if (obj.Url != url)
            {
                return RedirectToAction("Detail", "Product", new { url = obj.Url, id = obj.Id });
            }

            return View(obj);
        }
    }
}