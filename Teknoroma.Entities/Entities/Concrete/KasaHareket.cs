using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class KasaHareket : BaseEntity
    {
        public string KasaId { get; set; }
        public string DovizId { get; set; }
        public string? HareketTipi { get; set; }
        public double? Giris { get; set; }
        public double? Cikis { get; set; }
        public double? Tutar { get; set; }
        public DateTime? Tarih { get; set; }

        // Navigation Properties
        public Kasa Kasa { get; set; }
        public Doviz Doviz { get; set; }
    }
}
