using Teknoroma.Entities.Entities.Abstract;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class Tedarikci : BaseEntity
    {
        public string? Ad { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }
        public string? Adres { get; set; }
    }
}
