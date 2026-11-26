using Day_3.Models;

namespace Day_3.Repository
{
    public class CustomerRepo : ICustomer
    {
        private readonly MyDbContext db;

        public CustomerRepo(MyDbContext context) 
        {
            db = context;
        }

        public List<Customer> GetCust()
        {
            return db.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return db.Customers.Find(id);
        }

        public void AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            db.Customers.Update(customer);
            db.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = db.Customers.Find(id);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }
    }
}