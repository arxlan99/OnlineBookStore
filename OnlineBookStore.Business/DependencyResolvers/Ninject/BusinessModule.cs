using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using OnlineBookStore.Business.Abstract;
using OnlineBookStore.Business.Concrete;
using OnlineBookStore.DataAccess.Abstract;
using OnlineBookStore.DataAccess.Concrete.EntityFramework;

namespace OnlineBookStore.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();

            Bind<IItemToPurchaseService>().To<ItemToPurchaseManager>().InSingletonScope();
            Bind<IItemToPurchaseDal>().To<EfItemToPurchaseDal>().InSingletonScope();

            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<IShoppingCartService>().To<ShoppingCartManager>().InSingletonScope();
            Bind<IShoppingCartDal>().To<EfShoppingCartDal>().InSingletonScope();

            Bind<IOrderService>().To<OrderManager>().InSingletonScope();
            Bind<IOrderDal>().To<EfOrderDal>().InSingletonScope();

            Bind<IOrderedProductService>().To<OrderedProductManager>().InSingletonScope();
            Bind<IOrderedProductDal>().To<EfOrderedProductDal>().InSingletonScope();
        }
    }
}
