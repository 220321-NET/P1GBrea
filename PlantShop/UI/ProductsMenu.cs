using BL;
using Models;
namespace UI;

public class ProductsMenu
{
    // public void Start()
    private readonly IPSBL _bl;
    public ProductsMenu(IPSBL bl)
    {
        _bl = bl;
    }
    public void DisplayAllProducts()
    {
        Console.WriteLine("Select which plant you'd like to buy:");
        // List<Products> allProducts = _bl.GetProducts();

        // foreach (Products productsToDisplay in allProducts)
        // {
        //     Console.WriteLine($"Name: {Products.Name}, Cost: {Products.Cost}");
        // }
        // if (allProducts.Count == 0)
        // {
        //     Console.WriteLine("No stock available.");
        //     return;
        // }


        // for (int i = 0; i < allProducts.Count; i++)
        // {
        //     Console.WriteLine($"[{i}] {allProducts[i]}");
        // }
        // int selection;
        // if (Int32.TryParse(Console.ReadLine(), out selection) && (selection >= 0 || selection < allProducts.Count))
        // {
        //     return;
        // }
        // else
        // {
        //     Console.WriteLine("Please enter valid input");
        //     return;
        // }
    }
}