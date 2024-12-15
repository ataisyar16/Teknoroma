using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class StokFotograf : BaseEntity
    {
        public string StokId { get; set; }
        public string? FotografYolu { get; set; }

        // Navigation Property
        public Stok Stok { get; set; }
    }
}