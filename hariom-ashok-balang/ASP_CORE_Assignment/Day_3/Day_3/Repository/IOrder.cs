namespace Day_3.Repository
{
    public interface IOrder
    {
        List<Order> GetOrders();
        Order GetById(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
