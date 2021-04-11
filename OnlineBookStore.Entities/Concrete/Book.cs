using OnlineBookStore.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookStore.Entities.Concrete
{
    [Table("Books")]
    public class Book : Product
    {
        public string IsbnNumber { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Page { get; set; }
    }
}
