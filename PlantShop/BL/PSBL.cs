using DL;
namespace BL;

public class PSBL : IPSBL
{
    private readonly IRepository _repo;
    public PSBL(IRepository repo)
    {
        _repo = repo;
    }
    //Customer/SignIn Verification
    public List<Customers> GetCustomers()
    {
        return _repo.GetCustomers();
    }
    //     public int SignInCheck(string userName, string password)
    // {
    //     throw new NotImplementedException();
    // }

    // SignUp

    public Customers CreateCustomer(Customers newCustomer)
    {
        return _repo.CreateCustomer(newCustomer);
    }

    //ProductsMenu
    public void DisplayAllProducts()
    {
        _repo.DisplayAllProducts();
    }

    public List<Products> GetProducts(Products getProducts)
    {
        throw new NotImplementedException();
    }

    void IPSBL.DisplayAllProducts()
    {
        throw new NotImplementedException();
    }


    //CartMenu
    // public class CartMenu
    // {
    //     // return _repo.DisplayAllCart();
    // }

    //OrdersMenu
    // public class OrdersMenu
    // {
    //     return _repo.?();
    // }
}
