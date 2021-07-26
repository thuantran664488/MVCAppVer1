using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;

namespace Webservice
{
    public class Helper
    {
        static ProductService.ProductSvc productSvc = new ProductService.ProductSvc();
        public static ProductService.ProductDTOResponse getProducts(int PageSize, int PageIndex)
        {

            var getProducts = productSvc.GetProducts(PageSize, PageIndex);
            //return productSvc.GetProducts(PageSize, PageIndex).ListProducts;

            return getProducts;

        }

        public static ProductService.ProductDTOResponse searchProduct(int PageSize, int PageIndex, string keyword, double minPrice, double maxPrice)
        {
            var getProducts = productSvc.SearchProducts(PageSize, PageIndex, keyword, minPrice, maxPrice);
            return getProducts;
        }

        public static ProductService.ProductDTO getProductById(int productId)
        {
            var getProduct = productSvc.GetProductById(productId);
            return getProduct;
        }

    }
}
