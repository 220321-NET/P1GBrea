using BL;
using DL;
using Models;


namespace UI;

//main class
public class PlantShop
{
    private readonly IPSBL _bl;
    public PlantShop(IPSBL bl)
    {
        _bl = bl;
    }
    public void Start()
    {
        //greeting method
        GreetUser();
    }
    public void GreetUser()
    {
        //greet user
        Console.WriteLine("Welcome to PlantShop");
        Console.WriteLine("Have you been here before?[Y/N]");
        //get answer
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y")
        {
            SignIn();
        }
        else if (answer == "N")
        {
            SignUp();
        }
        else
        {
            return;
        }
    }
    public void SignIn()
    {
    here:
        //ask for user name
        Console.WriteLine("What is your username?");
        string? userName = Console.ReadLine();

        //ask for password
        Console.WriteLine("What is your password?");
        string? password = Console.ReadLine();

        //verify userName and Password to sign in user
        List<Customers> allCustomers = _bl.GetCustomers();

        foreach (Customers customer in allCustomers)
        {
            if (customer.Username == userName && customer.Password == password)
            {
                //take to MainMenu
                MainMenu mainmenu = new MainMenu();
                mainmenu.Start();
            }
        }

        //if can't verify user ask to try again [y/n]
        Console.WriteLine("Unable to verify user would you like to try again?[Y/N]");
        //get answer
        string answer = Console.ReadLine().ToUpper();

        //if y take to signin
        if (answer == "Y")
        {
            goto here;
        }
        //if n take to signup
        else if (answer == "N")
        {
            SignUp();
        }
        else
        {
            return;
        }

        //greet returning user
        Console.WriteLine("Welcome back ", userName);

    }
    public void SignUp()
    {
        //ask user to create username
        Console.WriteLine("What would you like your username to be?");
        string? userName = Console.ReadLine();

        //make sure username is unique

        //ask user to create password
        Console.WriteLine("What would you like your password to be?");
        string? password = Console.ReadLine();

        //create new user in db
        // new PSBL().CreateCustomer(newCustomer);
        Console.WriteLine("Your account has been created.");

        { //take to SignIn
            SignIn();
        }

    }
}

