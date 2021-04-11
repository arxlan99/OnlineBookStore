using OnlineBookStore.Business.Abstract;
using OnlineBookStore.DataAccess.Abstract;
using OnlineBookStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public int CreateAndReturnOrderId(Order order)
        {
            _orderDal.Add(order);
            return _orderDal.Get(x => x.OrderDate == order.OrderDate).Id;
        }

        public int GetOrderIdByDate(string date)
        {
            return _orderDal.Get(x => x.OrderDate == date).Id;
        }

        public List<Order> GetOrdersIdByCustomerId(int customerId)
        {
            var orders = _orderDal.GetAll(x => x.CustomerId == customerId);
            return orders;
        }

        public void DeleteOrderByOrderId(int orderId)
        {
            _orderDal.Delete(new Order
            {
                Id = orderId
            });
        }

        public void SendInvoiceByEmail(Customer customer, int orderId)
        {
            var order = _orderDal.Get(x => x.Id == orderId);

            string message = "Siparişiniz alınmıştır.\n\n" +
                "Sipariş tarihi: " + order.OrderDate + "\n" +
                "Ödeme tipi: " + order.PaymentType + "\n" +
                "Toplam fiyat: " + order.PaymentAmount + " TL\n" +
                "Teslimat adresi: " + customer.Address + "\n\n";

            SendEmail(customer, orderId, message,"Alışveriş Fatura - Online Book Store");
        }

        public void SendInfoAboutCancelOrderByEmail(Customer customer, int orderId)
        {
            var order = _orderDal.Get(x => x.Id == orderId);

            string message = order.OrderDate + " tarihli yapılan siparişiniz tarafınızca iptal edilmiştir.";

            SendEmail(customer, orderId, message,"Sipariş İptali - Online Book Store");
        }

        public void SendInvoiceByPhone(LoginedCustomer customer, int orderId)
        {

        }

        private void SendEmail(Customer customer, int orderId, string invoiceContent,string mailSubject)
        {
            MailMessage message = new MailMessage();
            SmtpClient process = new SmtpClient();
            process.Credentials = new System.Net.NetworkCredential("EsoguStore@outlook.com", "987654321esogu");
            process.Port = 587;
            process.Host = "smtp-mail.outlook.com";
            process.EnableSsl = true;
            message.To.Add(customer.Email);
            message.From = new MailAddress("EsoguStore@outlook.com");
            message.Subject = mailSubject;

            message.Body = invoiceContent;
            process.Send(message);
        }
    }
}
