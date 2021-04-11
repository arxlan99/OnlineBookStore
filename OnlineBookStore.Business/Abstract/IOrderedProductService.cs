using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.Business.Abstract
{
    public interface IOrderedProductService
    {
        void Add(OrderedProduct orderedProduct);
        List<OrderedProduct> GetAll(int orderId);
        void DeleteProductsByOrderId(int orderId);
    }
}
