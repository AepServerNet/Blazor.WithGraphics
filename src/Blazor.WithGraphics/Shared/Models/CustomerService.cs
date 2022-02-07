using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.WithGraphics.Shared.Models
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomers()
        {
            var customerList = new List<Customer>();
            var rand = new Random();

            for (int i = 1; i <= 100; i++)
            {
                var customer = new Customer
                {
                    Id = i,
                    FirstName = "FirstName_" + i.ToString(),
                    LastName = "LastName_" + i.ToString(),
                    PhoneNumber = "0123456789"
                };
                customerList.Add(customer);
            }

            List<Customer> people = customerList;

            return people.ToList();
        }
    }
}