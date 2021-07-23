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
    }

}
