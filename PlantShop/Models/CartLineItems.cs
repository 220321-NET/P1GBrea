namespace Models;

public class Cart
{
    public int Id { get; set; }
    public int productId { get; set; }
    public int quantity { get; set; }
    public int orderId { get; set; }
}