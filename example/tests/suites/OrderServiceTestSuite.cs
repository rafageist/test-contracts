using NUnit.Framework;

[TestFixture]
public class OrderServiceTests : IOrderServiceContractTests
{
    private IOrderService _orderService;

    [SetUp]
    public void Setup()
    {
        _orderService = new OrderService();
    }

    [Test]
    public void Should_PlaceOrder_ReturnTrue_WhenStockIsSufficient()
    {
        // Arrange
        int productId = 1; // Product ID exists in stock
        int quantity = 5;

        // Act
        var result = _orderService.PlaceOrder(productId, quantity);

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual(5, _orderService.GetStockLevel(productId));
    }

    [Test]
    public void Should_PlaceOrder_ReturnFalse_WhenStockIsInsufficient()
    {
        // Arrange
        int productId = 1; // Product ID exists in stock
        int quantity = 20; // More than available stock

        // Act
        var result = _orderService.PlaceOrder(productId, quantity);

        // Assert
        Assert.IsFalse(result);
        Assert.AreEqual(10, _orderService.GetStockLevel(productId)); // Stock remains unchanged
    }

    [Test]
    public void Should_GetStockLevel_ReturnCorrectValue()
    {
        // Arrange
        int productId = 2;

        // Act
        var stockLevel = _orderService.GetStockLevel(productId);

        // Assert
        Assert.AreEqual(5, stockLevel);
    }
}
