using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Satis : BaseEntity
    {
        public string CariId { get; set; }
        public string PersonelId { get; set; }
        public string SubeId { get; set; }
        public DateTime? SatisTarihi { get; set; }
        public double ToplamTutar { get; set; }

        // Navigation Properties
        public Cari Cari { get; set; }
        public Personel Personel { get; set; }
        public Sube Sube { get; set; }
        public ICollection<SatisDetay> SatisDetaylari { get; set; }
    }
}
