using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Sube : BaseEntity
    {
        public string? SubeAdi { get; set; }
        public string? Sehir { get; set; }
        public string? Ilce { get; set; }
        public string? Address { get; set; }

        // Navigation Properties
        public ICollection<Depo> Depolar { get; set; }
        public ICollection<Personel> Personeller { get; set; }
        public ICollection<Satis> Satislar { get; set; }
    }
}
