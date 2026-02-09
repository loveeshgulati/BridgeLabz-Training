
public class ECommerceServices:IECommerceServices
{
    Stack<Order> orderStack = new Stack<Order>();
     public Stack<Order> AddOrderDetails(int orderId, string customerName, string item)
    {
        orderStack.Push(new Order{orderID = orderId, customerName = customerName,item=item});
        return orderStack;
    }
    public string GetOrderDetails()
    {
        if(orderStack.Count == 0)
        {
            return "No Orders Found";
        }
        else
        {
        return $"OrderId = {orderStack.Peek().orderID}, CustomerName = {orderStack.Peek().customerName}, Item = {orderStack.Peek().item}";}
    }
    public Stack<Order> RemoveOrderDetails() 
    { 
        if (orderStack.Count == 0) 
    {
        Console.WriteLine("No Orders Found");
    }
    else
    {
        var removed = orderStack.Pop();
        Console.WriteLine($"Order {removed.orderID} removed.");
    }
    return orderStack; 
    }
     
}
