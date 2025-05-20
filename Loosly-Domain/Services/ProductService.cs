using Loosly_Domain.Interfaces;
using Loosly_Domain.Repositories;
using Loosly_Domain.ViewModels;

namespace Loosly_Domain.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IUserContext _userContext;

    public ProductService(IProductRepository productRepository, IUserContext userContext)
    {
        if (productRepository == null)
        {
            throw new ArgumentNullException(nameof(productRepository));
        }
        
        if (userContext == null)
        {
            throw new ArgumentNullException(nameof(userContext));
        }
        _productRepository = productRepository;
        _userContext = userContext;
    }

    public IEnumerable<DiscountedProduct> GetFeaturedProducts()
    {
        return _productRepository.GetFeaturedProducts()
             .Select(p => p.ApplyDiscountFor(_userContext))
             .ToList();
    }
}
