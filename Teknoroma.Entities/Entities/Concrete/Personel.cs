using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Personel : BaseEntity
    {
        public string SubeId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? TcNo { get; set; }
        public string DepartmanId { get; set; }
        public bool? Cinsiyet { get; set; }
        public string? Gorev { get; set; }

        // Navigation Properties
        public Sube Sube { get; set; }
        public Departman Departman { get; set; }

        public ICollection<Satis> Satislar { get; set; } = new List<Satis>();
    }
}
