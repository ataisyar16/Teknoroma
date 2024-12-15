using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Doviz : BaseEntity
    {
        public string DovizKodu { get; set; }
        public string DovizAdi { get; set; }
        public decimal Kur { get; set; }

        // Navigation Properties
        public ICollection<KasaHareket> KasaHareketleri { get; set; }
        public ICollection<Kasa> Kasalar { get; set; }
        public ICollection<Kur> Kurlar { get; set; }
    }
}
