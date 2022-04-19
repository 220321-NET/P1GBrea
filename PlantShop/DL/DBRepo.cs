using System.Data;
using Microsoft.Data.SqlClient;
using Models;

namespace DL;

public class DBRepo : IRepository
{
    private readonly string _connectionString;
    public DBRepo(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    //verifying SignIn
    public List<Customers> GetCustomers()
    {
        List<Customers> AllCustomers = new List<Customers>();
        
        using SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();
        using SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", connection);
        SqlDataReader read = cmd.ExecuteReader();
        while (read.Read())
        {
            string username = read.GetString(1);
            string password = read.GetString(2);
            Customers profiles = new Customers
            {
                Username = username,
                Password = password,

            };
            AllCustomers.Add(profiles);
        }
        read.Close();
        connection.Close();
        return AllCustomers;
    }
    //SignUp
    public Customers CreateCustomer(Customers newCustomer)
    {
        using SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();
        using SqlCommand cmd = new SqlCommand("INSERT INTO Customers(username, password) OUTPUT INSERTED.Id Values (@username, @password)", connection);
        cmd.ExecuteScalar();
        connection.Close();
        return newCustomer;
    }
    // Display Products
    public List<Products> GetProducts(Products getProducts)
    {
        List<Products> productStock = new List<Products>();
        using SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();
        using SqlCommand cmd = new SqlCommand("SELECT * FROM Products", connection);
        SqlDataReader read = cmd.ExecuteReader();
        while (read.Read())
        {

            string name = read.GetString(1);
            double cost = read.GetDouble(2);
            {
                name = name;
                cost = cost;
            };
            return productStock;
        }
        read.Close();
        connection.Close();
        return productStock;
    }

    public void DisplayAllStock()
    {
        throw new NotImplementedException();
    }

    public void DisplayAllProducts()
    {
        throw new NotImplementedException();
    }

    public List<Products> GetProducts()
    {
        throw new NotImplementedException();
    }
    // public void UpdateOrder(Cart cartItem, int storeID)
    // {
    //     using SqlConnection connection = new SqlConnection(_connectionString);
    //     connection.Open();
    //     int newQuantity = 0;
    //     using SqlCommand cmd2 = new SqlCommand("SELECT * FROM STOCK WHERE productID = @productID AND storeID = @storeID", connection);
    //     cmd2.Parameters.AddWithValue("@productID", cartItem.productId);
    //     cmd2.Parameters.AddWithValue("@storeID", storeID);
    //     SqlDataReader read = cmd2.ExecuteReader();
    //     if (read.Read())
    //     {
    //         newQuantity = (read.GetInt32(1) - cartItem.quantity);
    //         read.Close();
    //         using SqlCommand cmd = new SqlCommand("UPDATE STOCK SET quantity = @quantity WHERE productID = @productID and storeID = @storeID", connection);
    //         cmd.Parameters.AddWithValue("@quantity", newQuantity);
    //         cmd.Parameters.AddWithValue("@productID", cartItem.productId);
    //         cmd.Parameters.AddWithValue("@storeID", storeID);
    //         cmd.ExecuteScalar();
    //     }
    //     connection.Close();
    // }
    // public Orders UpdateOrdersProducts(Orders UpdateOrder)
    // {
    //     using SqlConnection connection = new SqlConnection(_connectionString);
    //     connection.Open();
    //     using SqlCommand cmd = new SqlCommand("INSERT INTO ORDERS (total, storeID, customerID) OUTPUT INSERTED.Id VALUES (@total, @storeID, @customerID", connection);
    //     cmd.Parameters.AddWithValue("@total", UpdateOrder.Total);
    //     cmd.Parameters.AddWithValue("@storeID", UpdateOrder.StoreId);
    //     cmd.Parameters.AddWithValue("@customerID", UpdateOrder.CustomerId);
    //     connection.Close();
    //     return UpdateOrder;
    // }

    // public Products GetProducts(int id)
    // {
    //     Products temp = new Products();
    //     using SqlConnection connection = new SqlConnection(_connectionString);
    //     connection.Open();
    //     using SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE id = @productID", connection);
    //     cmd.Parameters.AddWithValue("@productID", id);
    //     SqlDataReader read = cmd.ExecuteReader();
    //     if (read.Read())
    //     {
    //         string name = read.GetString(1);
    //         double cost = read.GetDouble();
    //         temp.name = name;
    //         temp.cost = cost;
    //     }
    //     read.Close();
    //     return temp;
    // }
}