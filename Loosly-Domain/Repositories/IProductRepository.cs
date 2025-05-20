using Loosly_Domain.Models;

namespace Loosly_Domain.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetFeaturedProducts();
}
