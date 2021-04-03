using CustomerManagementSystem.Core.Repositories.Interfaces;
using CustomerManagementSystem.Core.Services.Interfaces;
using CustomerManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
    }
}
