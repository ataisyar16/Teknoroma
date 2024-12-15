using Microsoft.AspNetCore.Identity;

namespace Teknoroma.Entities.Entities.Concrete
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } // Kullanıcının adı
        public string LastName { get; set; }  // Kullanıcının soyadı
        public string PersonelId { get; set; } // Personel ile ilişki (Opsiyonel)

        // Navigation Property
        public Personel Personel { get; set; }
        public ICollection<KullaniciYorum> Yorumlar { get; set; } = new List<KullaniciYorum>();
    }
}
