using System.ComponentModel.DataAnnotations;

namespace CookieAuthentication.Model.Entities
{
    public class User
    {

        public int UserID { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        [MaxLength(20)]
        public string Role { get; set; }
    }
}
