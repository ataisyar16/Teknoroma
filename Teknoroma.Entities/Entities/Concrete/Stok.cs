using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Stok : BaseEntity
    {
        public string? StokAdi { get; set; }
        public string? StokKodu { get; set; }
        public string DepoId { get; set; }
        public int? StokAdet { get; set; }
        public string BirimId { get; set; }
        public double? Fiyat { get; set; }

        // Navigation Properties
        public Depo Depo { get; set; }
        public Birim Birim { get; set; }
        public ICollection<StokBarkod> StokBarkodlari { get; set; }
        public ICollection<StokFotograf> StokFotograflari { get; set; }
        public ICollection<FaturaDetay> FaturaDetaylari { get; set; }
        public ICollection<SatisDetay> SatisDetaylari { get; set; }
        public ICollection<StokHareket> StokHareketleri { get; set; }
        public ICollection<KullaniciYorum> KullaniciYorumlari { get; set; }
    }
}
