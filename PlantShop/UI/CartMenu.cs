using Models;
namespace UI;

public class CartMenu
{
    public void Start()
    {
        //CartMenu:
        Console.WriteLine("Here is your cart, would you like to proceed?[Y/N]");
        //DisplayAllCart();
        string answer = Console.ReadLine().ToUpper();

        //if y take to OrdersMenu
        if (answer == "Y")
        {
            Console.WriteLine("Order has been placed.");
            //send order to db
            //Exit
        }
        //if n take to MainMenu
        else if (answer == "N")
        {
            //Take back to MainMenu
            MainMenu mainmenu = new MainMenu();
            mainmenu.Start();
        }
        else
        {
            return;
        }
    }

}