using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.WithGraphics.Shared.Models
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}