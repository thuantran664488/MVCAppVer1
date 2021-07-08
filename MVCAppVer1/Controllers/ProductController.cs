using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppVer1.Models;

namespace MVCAppVer1.Controllers
{
    public class ProductController : HomeController
    {
        // GET: Product/Phone
        public ActionResult Phone()
        {
            var iPhone = new Product() { Name = "IPhone X" };
            return View(iPhone);
        }

        

        // GET: Product/detail/id
        public ActionResult detail(string id)
        {
            if (string.IsNullOrEmpty(id)) return null;

            var lst = GetListProducts();
            if (lst == null || lst.Count == 0) return null;

            var obj = lst.FirstOrDefault(p => p != null && p.Id.Equals(id));
            if (obj == null) return null;

            //var product = new Product()
            //{
            //    Id = id,
            //};

            //if (id == "1")
            //{
            //    product.Name = "Bàn Làm Việc Kết Hợp Kệ Sách Thông Minh";
            //    product.price = 48.100;
            //    product.url = "/Content/src/Image/ban_lam_viec.jpg";
            //}
            //if (id == "2")
            //{
            //    product.Name = "Hộp/ Túi đựng sạc và phụ kiện Macbook Lucas - Hàng chính hãng";
            //    product.price = 98.000;
            //    product.url = "/Content/src/Image/hop_dung_linh_lien_macbook.png";
            //}
            //if (id == "3")
            //{
            //    product.Name = "Bao Case Cho Airpods 1/ Airpods 2 Dạ Quang Phát Sáng - Xanh Dương";
            //    product.price = 140.000;
            //    product.url = "/Content/src/Image/case_airpod.jpg";
            //}
            //if (id == "4")
            //{
            //    product.Name = "Smart Tivi LG 4K 55 inch 55UM7600PTA";
            //    product.price = 978.0000;
            //    product.url = "/Content/src/Image/smart_tv.jpg";
            //}
            //if (id == "5")
            //{
            //    product.Name = "BỘ ĐẦU THU TRUYỀN HÌNH KỸ THUẬT SỐ K+ 7 MÓN HÀNG CHÍNH HÃNG";
            //    product.price = 450.000;
            //    product.url = "/Content/src/Image/dau_thu.jpg";
            //}
            //if (id == "6")
            //{
            //    product.Name = "Ghế Giám đốc IHC10113";
            //    product.price = 790.000;
            //    product.url = "/Content/src/Image/ghe_giam_doc.jpg";
            //}
            //if (id == "7")
            //{
            //    product.Name = "Vỏ bảo vệ bao đựng tai nghe Kaws airpod 1/2";
            //    product.price = 39.000;
            //    product.url = "/Content/src/Image/case__kaws_aripod.jpg";
            //}
            //if (id == "8")
            //{
            //    product.Name = "Summer Korean Style Simple Striped Loose Sleeveless Vest Top T-Shirt";
            //    product.price = 980.000;
            //    product.url = "/Content/src/Image/top_t_shirt.jpg";
            //}
            //if (id == "9")
            //{
            //    product.Name = "Miếng dán Kính Cường Lực full 3D cho iPhone XR / iPhone 11 6.1 inch hiệu Nillkin XD CP+Max - Hàng Chính Hãng";
            //    product.price = 90.000;
            //    product.url = "/Content/src/Image/dan_cuong_luc.jpg";
            //}
            //if (id == "10")
            //{
            //    product.Name = "Bao da bê Epsom Xanh chính hãng HANHSON cho Apple AirPods Pro";
            //    product.price = 90.000;
            //    product.url = "/Content/src/Image/bao_da_airpod.jpg";
            //}

            return View(obj);
        }

        // GET: Product/detail ->  Redirecto to Home page
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}