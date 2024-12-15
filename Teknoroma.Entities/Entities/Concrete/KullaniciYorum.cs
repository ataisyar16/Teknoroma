using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class KullaniciYorum : BaseEntity
    {
        public string KullaniciId { get; set; }
        public string StokId { get; set; }
        public string? YorumMetni { get; set; }
        public DateTime YorumTarihi { get; set; }

        // Navigation Properties
        public AppUser Kullanici { get; set; }
        public Stok Stok { get; set; }
    }
}
