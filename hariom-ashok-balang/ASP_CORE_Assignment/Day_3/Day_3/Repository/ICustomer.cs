using Day_3.Models;

namespace Day_3.Repository
{
    public interface ICustomer
    {
        List<Customer> GetCust();
        Customer GetById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
