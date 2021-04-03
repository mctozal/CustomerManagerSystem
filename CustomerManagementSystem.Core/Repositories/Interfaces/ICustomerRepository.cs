using CustomerManagementSystem.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.Core.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
         CustomerDBContext GetContext();
    }
}
