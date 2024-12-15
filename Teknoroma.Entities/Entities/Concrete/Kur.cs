using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Kur : BaseEntity
    {
        public string DovizId { get; set; }
        public DateTime? KurTarihi { get; set; }
        public double? AlisKuru { get; set; }
        public double? SatisKuru { get; set; }

        // Navigation Property
        public Doviz Doviz { get; set; }
    }
}
