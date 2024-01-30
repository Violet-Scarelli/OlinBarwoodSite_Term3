using System.ComponentModel.DataAnnotations;

namespace OlinBarwoodSite_Term2.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password don't match")]
        public string ConfirmPassword { get; set;}

    }
}
