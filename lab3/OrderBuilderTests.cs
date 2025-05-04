using NUnit.Framework;

[TestFixture]
public class OrderBuilderTests
{
    [Test]
    public void Build_WithDefaultValues_CreatesOrderWithDefaults()
    {
        var order = new OrderBuilder().Build();

        Assert.AreEqual(1, order.Id);
        Assert.AreEqual("Default Customer", order.CustomerName);
        Assert.AreEqual(100.0m, order.TotalAmount);
    }

    [Test]
    public void Build_WithCustomValues_CreatesOrderWithSpecifiedValues()
    {
        var order = new OrderBuilder()
            .WithId(42)
            .WithCustomerName("Alice")
            .WithTotalAmount(250.0m)
            .Build();

        Assert.AreEqual(42, order.Id);
        Assert.AreEqual("Alice", order.CustomerName);
        Assert.AreEqual(250.0m, order.TotalAmount);
    }

    [Test]
    public void Build_WithPartialCustomValues_CreatesOrderWithMixedValues()
    {
        var order = new OrderBuilder()
            .WithCustomerName("Bob")
            .Build();

        Assert.AreEqual(1, order.Id);
        Assert.AreEqual("Bob", order.CustomerName);
        Assert.AreEqual(100.0m, order.TotalAmount);
    }
}