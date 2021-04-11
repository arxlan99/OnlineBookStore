using OnlineBookStore.DataAccess.Abstract;
using OnlineBookStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepositoryBase<Product, BookStoreContext>, IProductDal
    {
    }
}
