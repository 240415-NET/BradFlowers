public class OrderManagement
{
    
    private List<Order> Inventory = new List<Order>();
    public List<Order> Orders = new List<Order>();
    
    public OrderManagement()
    {
        Inventory.Add(new Order("Pizza", 10));
        Inventory.Add(new Order("Burger", 5));
        Inventory.Add(new Order("Fries", 3));
        Inventory.Add(new Order("Soda", 2));
    }
    
    
    public bool AddOrder(string order)
    {
        var orderItem = Inventory.FirstOrDefault(o => o.Name.ToLower() == order.ToLower());
        if (orderItem != null)
        {
            Orders.Add(orderItem);
            return true;
        }

        return false;
    }
}