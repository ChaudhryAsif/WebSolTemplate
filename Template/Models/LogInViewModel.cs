using System.ComponentModel.DataAnnotations;

namespace MultiTanet.Models
{
    public class LogInViewModel
    {
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
