public interface IOrderService
{
    bool PlaceOrder(int productId, int quantity);
    int GetStockLevel(int productId);
}
