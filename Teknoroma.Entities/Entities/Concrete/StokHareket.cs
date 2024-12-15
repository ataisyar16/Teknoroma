using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class StokHareket : BaseEntity
    {
        public string StokId { get; set; }
        public string DepoId { get; set; }

        public int Adet { get; set; }
        public DateTime Tarih { get; set; }

        // Navigation Properties
        public Stok Stok { get; set; }
        public Depo Depo { get; set; }

    }
}