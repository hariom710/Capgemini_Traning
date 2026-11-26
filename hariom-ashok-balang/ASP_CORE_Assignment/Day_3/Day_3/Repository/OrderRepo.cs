using Day_3.Models;

namespace Day_3.Repository
{
    public class OrderRepo : IOrder
    {
        MyDbContext db;

        public OrderRepo(MyDbContext _db)
        {
            db = _db;
        }

        public List<Order> GetOrders()
        {
            return db.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return db.Orders.Find(id);
        }

        public void AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            db.Orders.Update(order);
            db.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = db.Orders.Find(id);
            if (order != null)
            {
                db.Orders.Remove(order);
                db.SaveChanges();
            }
        }



    }
}
