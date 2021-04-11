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
    public class ItemToPurchaseManager : IItemToPurchaseService
    {
        private IItemToPurchaseDal _itemToPurchaseDal;

        public ItemToPurchaseManager(IItemToPurchaseDal itemToPurchaseDal)
        {
            _itemToPurchaseDal = itemToPurchaseDal;
        }

        public void AddProduct(ItemToPurchase itemToPurchase)
        {
            _itemToPurchaseDal.Add(itemToPurchase);
        }

        public void DeleteProduct(ItemToPurchase itemToPurchase)
        {
            _itemToPurchaseDal.Delete(itemToPurchase);
        }

        public List<ItemToPurchase> GetProducts(int shoppingCartId)
        {
            return _itemToPurchaseDal.GetAll(x => x.ShoppingCartId == shoppingCartId).ToList();
        }
    }
}
