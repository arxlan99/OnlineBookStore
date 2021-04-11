using OnlineBookStore.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBookStore.Entities.Concrete
{
    [Table("MusicCds")]
    public class MusicCd : Product
    {
        public string Singer { get; set; }
        public MusicTypes Type { get; set; }
    }

    public enum MusicTypes
    {
        Romance = 1,
        HardRock,
        Country
    }
}
