using System.ComponentModel.DataAnnotations;

namespace HandbookSystem.Models
{
    public class LoginModel
    {
        [Display(Name = "Username:")]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "Password:")]
        [Required]
        public string Password { get; set; }
    }
}