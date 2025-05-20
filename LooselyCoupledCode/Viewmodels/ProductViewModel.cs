using System.Globalization;

namespace LooselyCoupledCode.Viewmodels;

public class ProductViewModel
{
    private static CultureInfo _priceCulture = new CultureInfo("en-US");

    public ProductViewModel(string name, decimal unitPrice)
    {
        this.SummaryText= string.Format(_priceCulture, "{0} - {1:C}", name, unitPrice);
    }

    public string SummaryText { get; }
}
