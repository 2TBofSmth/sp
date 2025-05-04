public class Order
{
    public int Id { get; }
    public string CustomerName { get; }
    public decimal TotalAmount { get; }

    public Order(int id, string customerName, decimal totalAmount)
    {
        Id = id;
        CustomerName = customerName;
        TotalAmount = totalAmount;
    }
}
