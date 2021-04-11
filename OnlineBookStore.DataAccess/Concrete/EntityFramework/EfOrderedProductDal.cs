﻿using OnlineBookStore.DataAccess.Abstract;
using OnlineBookStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.DataAccess.Concrete.EntityFramework
{
    public class EfOrderedProductDal : EfRepositoryBase<OrderedProduct, BookStoreContext>, IOrderedProductDal
    {
    }
}
