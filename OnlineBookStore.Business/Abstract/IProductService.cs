using System.Collections;
using System.Collections.Generic;
using OnlineBookStore.Entities.Abstract;

namespace OnlineBookStore.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategories(int productType);
        Product GetById(int productId);
    }
}
