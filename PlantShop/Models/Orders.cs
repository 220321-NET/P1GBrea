namespace Models;
public class Orders
{
    public int Id { get; set; }
    public int DateCreated { get; set; }
    public int Number { get; set; }
    public int ProductId { get; set; }
    public int StoreId { get; set; }
    public int CustomerId { get; set; }
    public int Total { get; set; }
}