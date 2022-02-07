using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Blazor.WithGraphics.Shared;
using System.Linq;
using Blazor.WithGraphics.Shared.Models;
using System.Threading.Tasks;

namespace Blazor.WithGraphics.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public List<Customer> GetCustomersAsync()
        {
            List<Customer> people = customerService.GetCustomers();
            return people.ToList();
        }
    }
}
