using OnlineBookStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Business.Abstract
{
    public interface IItemToPurchaseService
    {
        void AddProduct(ItemToPurchase itemToPurchase);
        List<ItemToPurchase> GetProducts(int shoppingCartId);
        void DeleteProduct(ItemToPurchase itemToPurchase);
    }
}
