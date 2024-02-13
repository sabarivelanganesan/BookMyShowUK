using EMovieTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace EMovieTickets.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profie Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set;}

        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 letters")]
        [Required(ErrorMessage = "Fullname is required")]
        public string FullName { get; set;}

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set;}

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
