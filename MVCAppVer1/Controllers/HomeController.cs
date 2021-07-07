using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppVer1.Models;

namespace MVCAppVer1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = "1",
                    Name = "Bàn Làm Việc Kết Hợp Kệ Sách Thông Minh",
                    price = 48.100,
                    url = "/Content/src/Image/ban_lam_viec.jpg",
                },
                new Product
                {
                    Id = "2",
                    Name = "Hộp/ Túi đựng sạc và phụ kiện Macbook Lucas - Hàng chính hãng",
                    price = 98.000,
                    url = "/Content/src/Image/hop_dung_linh_lien_macbook.png",
                },
                new Product
                {
                    Id = "3",
                    Name = "Bao Case Cho Airpods 1/ Airpods 2 Dạ Quang Phát Sáng - Xanh Dương",
                    price = 140.000,
                    url = "/Content/src/Image/case_airpod.jpg",
                },
                new Product
                {
                    Id = "4",
                    Name = "Smart Tivi LG 4K 55 inch 55UM7600PTA",
                    price = 978.0000,
                    url = "/Content/src/Image/smart_tv.jpg",
                },
                new Product
                {
                    Id = "5",
                    Name = "BỘ ĐẦU THU TRUYỀN HÌNH KỸ THUẬT SỐ K+ 7 MÓN HÀNG CHÍNH HÃNG",
                    price = 450.000,
                    url = "/Content/src/Image/dau_thu.jpg",
                },
                new Product
                {
                    Id = "6",
                    Name = "Ghế Giám đốc IHC10113",
                    price = 790.000,
                    url = "/Content/src/Image/ghe_giam_doc.jpg",
                },
                new Product
                {
                    Id = "7",
                    Name = "Vỏ bảo vệ bao đựng tai nghe Kaws airpod 1/2",
                    price = 39.000,
                    url = "/Content/src/Image/case__kaws_aripod.jpg",
                },
                new Product
                {
                    Id = "8",
                    Name = "Summer Korean Style Simple Striped Loose Sleeveless Vest Top T-Shirt",
                    price = 980.000,
                    url = "/Content/src/Image/top_t_shirt.jpg",
                },
                new Product
                {
                    Id = "9",
                    Name = "Miếng dán Kính Cường Lực full 3D cho iPhone XR / iPhone 11 6.1 inch hiệu Nillkin XD CP+Max - Hàng Chính Hãng",
                    price = 90.000,
                    url = "/Content/src/Image/dan_cuong_luc.jpg",
                },
                new Product
                {
                    Id = "10",
                    Name = "Bao da bê Epsom Xanh chính hãng HANHSON cho Apple AirPods Pro",
                    price = 90.000,
                    url = "/Content/src/Image/bao_da_airpod.jpg",
                }

            };
            return View(products);
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