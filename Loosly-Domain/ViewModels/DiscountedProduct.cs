namespace Loosly_Domain.ViewModels;

public class DiscountedProduct
{
    public DiscountedProduct(string name, decimal unitPrice)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        Name = name;
        UnitPrice = unitPrice;
    }

    public string Name { get; }
    public decimal UnitPrice { get; }
}
