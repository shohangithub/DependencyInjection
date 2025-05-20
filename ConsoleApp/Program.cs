
using LooselyCoupledCode.Controllers;
using LooselyCoupledCode.Viewmodels;
using Loosly_Domain.Repositories;
using Loosly_Domain.Services;

public static class Program
{
    // This is the main entry point for the application.
    // It creates an instance of the CreateController class and passes a connection string to it.
    // The connection string is expected to be provided as a command-line argument.
    // The program then prints "Hello, World!" to the console.
    public static void Main(string[] args)
    {
        string connectionString = args[0];
        HomeController homeController = new CreateController(connectionString);
        
        var result = homeController.Index();

        var vm = (FeaturedProductsViewModel)result;

        Console.WriteLine("Featured products");

        foreach (var product in vm.Products)
        {
            Console.WriteLine(product.SummaryText);
        }
    }

    private static HomeController CreateController(string connectionString)
    {
        // This method creates an instance of the HomeController class.
        // It takes a connection string as a parameter and uses it to create an instance of the CommerceContext class.
        // The CommerceContext is then passed to the HomeController constructor.

        var userContext = new ConsoleUserContext();

        
        return new HomeController(new ProductService(new ProductRepository()));
    }
}