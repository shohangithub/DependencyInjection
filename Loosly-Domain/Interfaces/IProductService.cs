using Loosly_Domain.ViewModels;

namespace Loosly_Domain.Interfaces;

public interface IProductService
{
    IEnumerable<DiscountedProduct> GetFeaturedProducts();
}
