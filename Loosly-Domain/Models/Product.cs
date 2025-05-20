using Loosly_Domain.ViewModels;

namespace Loosly_Domain.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal UnitPrice { get; set; }
    public bool IsFeatured { get; set; }

    public DiscountedProduct ApplyDiscountFor(IUserContext user)
    {
        bool preferred = user.IsInRole(Role.PreferredCustomer);
        decimal discount = preferred ? .95m : 1.00m;
        return new DiscountedProduct(name: Name, unitPrice: UnitPrice * discount);
    }
}
