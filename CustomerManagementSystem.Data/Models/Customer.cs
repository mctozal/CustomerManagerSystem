using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerManagementSystem.Data.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public string NationalNumber { get; set; }
    }
}
