public class OrderBuilder
{
    private int _id = 1;
    private string _customerName = "Default Customer";
    private decimal _totalAmount = 100.0m;

    public OrderBuilder WithId(int id)
    {
        _id = id;
        return this;
    }

    public OrderBuilder WithCustomerName(string customerName)
    {
        _customerName = customerName;
        return this;
    }

    public OrderBuilder WithTotalAmount(decimal totalAmount)
    {
        _totalAmount = totalAmount;
        return this;
    }

    public Order Build()
    {
        return new Order(_id, _customerName, _totalAmount);
    }
}