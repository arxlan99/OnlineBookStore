using OnlineBookStore.Entities.Abstract;

namespace OnlineBookStore.Entities.Concrete
{
    public class ShoppingCart : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal? PaymentAmount { get; set; }
    }
}