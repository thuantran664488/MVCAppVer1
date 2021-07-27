using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using Webservice.ProductService;

namespace Webservice
{
    public class Service
    {
        private static Service instance;
        private ProductSvc productSvc;

        public static Service getInstance()
        {
            if (instance == null)
            {
                instance = new Service();
            }
            return instance;
        }

        public Service()
        {
            productSvc = new ProductSvc();
        }

        public ProductDTOResponse getProducts(int PageSize, int PageIndex)
        {

            var getProducts = productSvc.GetProducts(PageSize, PageIndex);
            //return productSvc.GetProducts(PageSize, PageIndex).ListProducts;

            return getProducts;

        }

        public ProductDTOResponse searchProduct(int PageSize, int PageIndex, string keyword, double minPrice, double maxPrice)
        {
            var getProducts = productSvc.SearchProducts(PageSize, PageIndex, keyword, minPrice, maxPrice);
            return getProducts;
        }

        public ProductDTO getProductById(int productId)
        {
            var getProduct = productSvc.GetProductById(productId);
            return getProduct;
        }

    }
}
