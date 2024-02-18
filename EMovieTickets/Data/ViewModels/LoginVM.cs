using System.ComponentModel.DataAnnotations;

namespace EMovieTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
