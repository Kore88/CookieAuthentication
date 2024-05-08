using System.ComponentModel.DataAnnotations;

namespace CookieAuthentication.Model.ViewModel
{
    public class LoginViewModel
    {

        [Required(AllowEmptyStrings = false,ErrorMessage = "Login Név kitöltése kötelező!")]
        public string Username { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage = "A Jelszó mező kitöltése kötlező!")]
        public string Password { get; set; }

    }
}
