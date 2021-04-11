using OnlineBookStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore.Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string OrderDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public PaymentTypes PaymentType { get; set; }
    }

    public enum PaymentTypes
    {
        Nakit = 1,
        KrediKartı
    }
}
