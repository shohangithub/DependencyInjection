using Loosly_Domain.Models;
using Loosly_Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loosely_DAL.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly CommerceContext _context;
    public ProductRepository(CommerceContext context)
    {
        if (context == null)
        {
            throw new ArgumentNullException(nameof(context));
        }
        _context = context;
    }
    public IEnumerable<Product> GetFeaturedProducts()
    {
        return _context.Products
            .Where(p => p.IsFeatured)
            .ToList();
    }
}
