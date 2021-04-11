using OnlineBookStore.Business.Abstract;
using OnlineBookStore.DataAccess.Abstract;
using OnlineBookStore.Entities.Abstract;
using OnlineBookStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Business.Concrete
{
    public class ShoppingCartManager : IShoppingCartService
    {
        private readonly IShoppingCartDal _shoppingCartDal;

        public ShoppingCartManager(IShoppingCartDal shoppingCartDal)
        {
            _shoppingCartDal = shoppingCartDal;
        }

        public void CreateShoppingCart(int customerId)
        {
            try
            {
                _shoppingCartDal.Add(new ShoppingCart
                {
                    CustomerId = customerId,
                    PaymentAmount = 0
                });
            }
            catch (Exception)
            { throw; }
        }

        public int GetShoppingCartId(int customerId)
        {
            return _shoppingCartDal.Get(x => x.CustomerId == customerId).Id;
        }
    }
}
