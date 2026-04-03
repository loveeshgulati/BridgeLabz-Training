public interface IECommerceServices
{
    public Stack<Order> AddOrderDetails(int orderId, string customerName, string item);
    public string GetOrderDetails();
    public Stack<Order> RemoveOrderDetails();
    
}