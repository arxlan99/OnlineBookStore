using OnlineBookStore.Entities.Concrete;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookStore.Entities.Abstract
{
    public abstract class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public string Image { get; set; }
    }
}
