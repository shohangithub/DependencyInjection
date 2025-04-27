using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ProductService
    {
        private readonly CommerceContext _commerceContext;
        public ProductService()
        {
            _commerceContext = new CommerceContext();
        }


        public IEnumerable<Product> GetFeaturesProducts(bool isCustomerPreffered)
        {
            decimal discount = isCustomerPreffered ? .95m : 1;
            return _commerceContext.Products.Where(x => x.IsFeatured == isCustomerPreffered).Select(x => new Product
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                IsFeatured = x.IsFeatured,
                UnitPrice = x.UnitPrice * discount,
            }).ToList();

        }

    }
}
