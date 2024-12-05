using Ecom.Server.Data;
using Ecom.Server.Models;
using Ecom.Server.Services.Infrastructure;

namespace Ecom.Server.Services.Repository
{
    public class CustomerRepository(ApplicationDbContext context) : ICustomer
    {
        public ApplicationDbContext _Context = context;

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            var customer = _Context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                return customer;
            }

            return null;
        }

        public void Insert(Customer customer)
        {
            _Context.Customers.Add(customer);
        }

        public void Update(Customer customer)
        {

            _Context.Customers.Update(customer);
        }

        public void Delete(int id)
        {
            var customer = _Context.Categories.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _Context.Categories.Remove(customer);
            }
        }

        public int Count()
        {
            return _Context.Categories.Count();
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
