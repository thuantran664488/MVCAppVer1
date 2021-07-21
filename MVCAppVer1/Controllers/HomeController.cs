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
        private const int PageSize = 10;

        static string RenderViewToString(ControllerContext context, string viewPath, object model = null, bool partial = false)
        {
            // first find the ViewEngine for this view
            ViewEngineResult viewEngineResult = null;
            if (partial)
                viewEngineResult = ViewEngines.Engines.FindPartialView(context, viewPath);
            else
                viewEngineResult = ViewEngines.Engines.FindView(context, viewPath, null);

            if (viewEngineResult == null)
                throw new FileNotFoundException("View cannot be found.");

            // get the view and attach the model to view data
            var view = viewEngineResult.View;
            context.Controller.ViewData.Model = model;

            string result = null;

            using (var sw = new StringWriter())
            {
                var ctx = new ViewContext(context, view, context.Controller.ViewData, context.Controller.TempData, sw);
                view.Render(ctx, sw);
                result = sw.ToString();
            }

            return result;
        }

        public ActionResult Index()
        {
            var totalProduct = GetListProducts();

            return View(totalProduct.Take(PageSize));
        }

        public ActionResult fetchData(int PageIndex)
        {
            var totalProduct = GetListProducts();
            var products = totalProduct.Skip(PageSize * PageIndex).Take(PageSize);
            var remain = totalProduct.Count - PageSize * PageIndex - PageSize;
            if (remain < 0) remain = 0;

            var JSON = Json(new
            {
                remain = remain,
                html = RenderViewToString(ControllerContext, "~/Views/Home/ListProduct.cshtml", products, true)
            });

            //return PartialView("ListProduct", totalProduct.Skip(PageSize * PageIndex).Take(PageSize));
            return JSON;

        }

        public List<Product> GetListProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = "1",
                    Name = "Bàn Làm Việc Kết Hợp Kệ Sách Thông Minh",
                    metaTitle = "ban-lam-viec-ket-hop-ke-sach-thong-minh",
                    price = 48.100,
                    url = "/Content/src/Image/ban_lam_viec.jpg",
                },
                new Product
                {
                    Id = "2",
                    Name = "Hộp/ Túi đựng sạc và phụ kiện Macbook Lucas - Hàng chính hãng",
                    metaTitle = "hop-tui-dung-sac-va-phu-kien-macbook-lucas",
                    price = 98.000,
                    url = "/Content/src/Image/hop_dung_linh_lien_macbook.png",
                },
                new Product
                {
                    Id = "3",
                    Name = "Bao Case Cho Airpods 1/ Airpods 2 Dạ Quang Phát Sáng - Xanh Dương",
                    metaTitle = "bao-case-cho-Aripods-1-Airpod-2-da-quang-phat-sang",
                    price = 140.000,
                    url = "/Content/src/Image/case_airpod.jpg",
                },
                new Product
                {
                    Id = "4",
                    Name = "Smart Tivi LG 4K 55 inch 55UM7600PTA",
                    metaTitle = "smart-tivi-lg-4k-55-inch-55UM7600PTA",
                    price = 3978.0000,
                    url = "/Content/src/Image/smart_tv.jpg",
                },
                new Product
                {
                    Id = "5",
                    Name = "BỘ ĐẦU THU TRUYỀN HÌNH KỸ THUẬT SỐ K+ 7 MÓN HÀNG CHÍNH HÃNG",
                    metaTitle = "bo-dau-thu-truyen-hinh-ky-thuat-so-k-7-mon-hang-hang",
                    price = 450.000,
                    url = "/Content/src/Image/dau_thu.jpg",
                },
                new Product
                {
                    Id = "6",
                    Name = "Ghế Giám đốc IHC10113",
                    metaTitle = "ghe-giam-doc-IHC10113",
                    price = 790.000,
                    url = "/Content/src/Image/ghe_giam_doc.jpg",
                },
                new Product
                {
                    Id = "7",
                    Name = "Vỏ bảo vệ bao đựng tai nghe Kaws airpod 1/2",
                    metaTitle = "vo-bao-ve-bao-dung-tai-nghe-kaws-aripod-1-2",
                    price = 39.000,
                    url = "/Content/src/Image/case__kaws_aripod.jpg",
                },
                new Product
                {
                    Id = "8",
                    Name = "Summer Korean Style Simple Striped Loose Sleeveless Vest Top T-Shirt",
                    metaTitle = "summer-korean-style-simeple-striped-loose-sleeveles-vest-top-t-shirt",
                    price = 980.000,
                    url = "/Content/src/Image/top_t_shirt.jpg",
                },
                new Product
                {
                    Id = "9",
                    Name = "Miếng dán Kính Cường Lực full 3D cho iPhone XR / iPhone 11 6.1 inch hiệu Nillkin XD CP+Max - Hàng Chính Hãng",
                    metaTitle = "mieng-dan-kinh-cuong-luc-full-3d-cho-iphong-xr-iphone-11-6-1-inch-hieu-nillkin-xd-cp-max",
                    price = 90.000,
                    url = "/Content/src/Image/dan_cuong_luc.jpg",
                },
                new Product
                {
                    Id = "10",
                    Name = "Bao da bê Epsom Xanh chính hãng HANHSON cho Apple AirPods Pro",
                    metaTitle = "bao-da-be-epsom-xanh-chinh-hang-hanhson-cho-apple-airpod-pro",
                    price = 90.000,
                    url = "/Content/src/Image/bao_da_airpod.jpg",
                }

            };
            return products;
        }
    }
}