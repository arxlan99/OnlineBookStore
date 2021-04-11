using OnlineBookStore.DataAccess.Abstract;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category, BookStoreContext>, ICategoryDal
    {
    }
}
