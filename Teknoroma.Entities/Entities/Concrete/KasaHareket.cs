using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class KasaHareket : BaseEntity
    {
        public string KasaId { get; set; }
        public string DovizId { get; set; }
        public string? HareketTipi { get; set; }
        public decimal? Giris { get; set; }
        public decimal? Cikis { get; set; }
        public decimal? Tutar { get; set; }
        public DateTime? Tarih { get; set; }

        // Navigation Properties
        public virtual Kasa Kasa { get; set; }
        public virtual Doviz Doviz { get; set; }
    }
}
