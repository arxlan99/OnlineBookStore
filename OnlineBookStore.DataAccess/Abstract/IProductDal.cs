using OnlineBookStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
    }
}
