/// <summary>
/// Defines the minimum tests required for the OrderService.
/// </summary>
public interface IOrderServiceContractTests
{
    void Should_PlaceOrder_ReturnTrue_WhenStockIsSufficient();
    void Should_PlaceOrder_ReturnFalse_WhenStockIsInsufficient();
    void Should_GetStockLevel_ReturnCorrectValue();
}
