using System.ComponentModel.DataAnnotations;

namespace OlinBarwoodSite_Term3.Models
{
    public class RegisterVM
    {
        [StringLength(255)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an email.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
