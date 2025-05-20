﻿namespace LooselyCoupledCode.Viewmodels;

public class FeaturedProductsViewModel
{
    public FeaturedProductsViewModel(IEnumerable<ProductViewModel> products)
    {
        Products = products;
    }

    public IEnumerable<ProductViewModel> Products { get; }
}
