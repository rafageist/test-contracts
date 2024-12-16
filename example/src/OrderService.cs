public class OrderService : IOrderService
{
    private readonly Dictionary<int, int> _stock;

    public OrderService()
    {
        _stock = new Dictionary<int, int>
        {
            { 1, 10 }, // Product ID 1 has 10 units in stock
            { 2, 5 }   // Product ID 2 has 5 units in stock
        };
    }

    public bool PlaceOrder(int productId, int quantity)
    {
        if (!_stock.ContainsKey(productId) || _stock[productId] < quantity)
            return false;

        _stock[productId] -= quantity;
        return true;
    }

    public int GetStockLevel(int productId)
    {
        return _stock.ContainsKey(productId) ? _stock[productId] : 0;
    }
}
