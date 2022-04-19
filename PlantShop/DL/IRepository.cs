using Models;
namespace DL;

public interface IRepository
{
    public List<Customers> GetCustomers();
    public Customers CreateCustomer(Customers newCustomer);
    public void DisplayAllProducts();
    public List<Products> GetProducts();
}