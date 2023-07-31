using System.ComponentModel.DataAnnotations;

namespace BlogSite.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Diğer profil bilgilerini eklemek isterseniz buraya ekleyebilirsiniz.
    }
}
