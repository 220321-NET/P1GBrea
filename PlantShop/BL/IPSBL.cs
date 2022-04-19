namespace BL;

public interface IPSBL
{
    public List<Customers> GetCustomers();
    public List<Products> GetProducts(Products getProducts);
    
    public void DisplayAllProducts();
    // public int SignInCheck(string userName, string password);
    //Task<List<OrdersHistory>> GetOrdersHistories;
    //Order UpdateOrders(Order updateOrder);
    //void UpdateQuantityOrder(Cart cartItem, int storeId);
    //
};
