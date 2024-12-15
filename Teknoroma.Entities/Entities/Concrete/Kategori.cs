using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Kategori : BaseEntity
    {
        public string? KategoriAdi { get; set; }

        // Navigation Properties
        public ICollection<Stok> Stoklar { get; set; }
    }
}
