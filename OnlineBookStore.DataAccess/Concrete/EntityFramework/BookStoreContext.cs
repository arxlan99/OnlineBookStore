using OnlineBookStore.Entities.Abstract;
using OnlineBookStore.Entities.Concrete;
using System.Data.Entity;

namespace OnlineBookStore.DataAccess.Concrete.EntityFramework
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ItemToPurchase> ItemToPurchases { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedProduct> OrderedProducts { get; set; }

        public BookStoreContext() : base("name=BookStoreContext")
        {
        }
    }
}
