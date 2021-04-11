using OnlineBookStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Business.Abstract
{
    public interface ICustomerService
    {
        Customer Get(string email, string password);
        void Add(Customer customer);
        Customer GetById(int customerId);
        void Update(Customer customer);
        void ChangePassword(Customer customer, string newPassword);
    }
}
