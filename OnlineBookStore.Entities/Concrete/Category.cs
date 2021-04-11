using OnlineBookStore.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookStore.Entities.Concrete
{
    public class Category : IEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
