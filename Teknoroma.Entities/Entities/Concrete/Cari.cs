using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Cari : BaseEntity
    {
        public string SubeNo { get; set; }
        public string CariHesapNo { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public decimal Bakiye { get; set; }

        // Navigation Properties
        public ICollection<Fatura> Faturalar { get; set; }
        public ICollection<Siparis> Siparisler { get; set; }
        public ICollection<Satis> Satislar { get; set; }
    }
}
