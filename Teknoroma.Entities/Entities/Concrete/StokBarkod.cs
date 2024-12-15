using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class StokBarkod : BaseEntity
    {
        public string StokId { get; set; }
        public string? Barkod { get; set; }

        // Navigation Properties
        public Stok Stok { get; set; }
    }
}
