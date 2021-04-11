using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetOrdersIdByCustomerId(int customerId);
        int CreateAndReturnOrderId(Order order);
        int GetOrderIdByDate(string date);
        void DeleteOrderByOrderId(int orderId);
        void SendInvoiceByEmail(Customer customer, int orderId);
        void SendInvoiceByPhone(LoginedCustomer customer, int orderId);
        void SendInfoAboutCancelOrderByEmail(Customer customer, int orderId);

    }
}
