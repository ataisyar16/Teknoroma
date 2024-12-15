using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class FaturaDetay : BaseEntity
    {
        public string FaturaId { get; set; }
        public string StokId { get; set; }
        public int? Miktar { get; set; }
        public double? Fiyat { get; set; }

        // Navigation Properties
        public Fatura Fatura { get; set; }
        public Stok Stok { get; set; }
    }
}
