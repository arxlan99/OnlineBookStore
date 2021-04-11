using OnlineBookStore.Business.Abstract;
using OnlineBookStore.DataAccess.Abstract;
using OnlineBookStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Business.Concrete
{
    public class OrderedProductManager : IOrderedProductService
    {
        private readonly IOrderedProductDal _orderedProductDal;

        public OrderedProductManager(IOrderedProductDal orderedProductDal)
        {
            _orderedProductDal = orderedProductDal;
        }

        public void Add(OrderedProduct orderedProduct)
        {
            _orderedProductDal.Add(orderedProduct);
        }

        public void DeleteProductsByOrderId(int orderId)
        {
            var products = GetAll(orderId);

            foreach (var product in products)
            {
                _orderedProductDal.Delete(product);
            }
        }

        public List<OrderedProduct> GetAll(int orderId)
        {
            return _orderedProductDal.GetAll(x => x.OrderId == orderId);
        }
    }
}
