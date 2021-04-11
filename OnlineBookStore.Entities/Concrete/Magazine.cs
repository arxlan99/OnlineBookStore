using OnlineBookStore.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookStore.Entities.Concrete
{
    [Table("Magazines")]
    public class Magazine : Product
    {
        public string Issue { get; set; }
        public MagazineTypes Type { get; set; }
    }

    public enum MagazineTypes
    {
        Actual=1,
        News,
        Sport,
        Computer,
        Technology
    }
}
