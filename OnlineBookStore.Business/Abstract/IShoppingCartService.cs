using OnlineBookStore.Entities.Abstract;
using System.Collections.Generic;

namespace OnlineBookStore.Business.Abstract
{
    public interface IShoppingCartService
    {
        void CreateShoppingCart(int customerId);
        int GetShoppingCartId(int customerId);
    }
}
