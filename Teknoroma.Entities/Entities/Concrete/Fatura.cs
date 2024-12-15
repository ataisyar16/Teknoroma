using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Fatura : BaseEntity
    {
        public string CariId { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
        public decimal KDV { get; set; }

        // Navigation Properties
        public Cari Cari { get; set; }
        public ICollection<FaturaDetay> FaturaDetaylari { get; set; }
    }
}
