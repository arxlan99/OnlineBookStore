using OnlineBookStore.DataAccess.Abstract;
using OnlineBookStore.Entities.Concrete;

namespace OnlineBookStore.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfRepositoryBase<Customer, BookStoreContext>, ICustomerDal
    {
    }
}
