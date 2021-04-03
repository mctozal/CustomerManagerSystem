using CustomerManagementSystem.Core.Repositories.Interfaces;
using CustomerManagementSystem.Data.Models;


namespace CustomerManagementSystem.Core.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDBContext _context;


        public CustomerRepository(CustomerDBContext context)
        {
            _context = context;
        }

        public CustomerDBContext GetContext()
        {
            return _context;
        }

    }
}
