using Models;
using System.Text;
using BL;
using DL;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Data.SqlClient;
namespace UI;

public class MainMenu
{
    public void Start()
    {
        bool exit = false;
        do
        {
            Console.WriteLine("Welcome to PlantShop!");
            Console.WriteLine("[1] Buy Plants");
            Console.WriteLine("[2] See Cart");
            Console.WriteLine("[3] View Past Order");
            Console.WriteLine("[x] Exit");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    // goto ProductsMenu;
                    // ProductsMenu productmenu = new ProductsMenu();
                    // productsmenu.Start();
                    break;

                case "2":
                    //Take to CartMenu
                    CartMenu cartmenu = new CartMenu();
                    cartmenu.Start();
                    break;

                case "3":
                    //Take to OrdersMenu;
                    OrdersMenu ordersmenu = new OrdersMenu();
                    ordersmenu.Start();
                    break;

                case "X":
                    Console.WriteLine("Thank you for visiting. Goodbye.");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid response, please try again.");
                    break;
            }

        } while (!exit);

    }
}