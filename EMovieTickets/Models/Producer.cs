using System.ComponentModel.DataAnnotations;

namespace EMovieTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        [Display(Name = "Profie Picture")]
        public string ProfilePictureURL { get; set;}

        [Display(Name = "Full Name")]
        public string FullName { get; set;}

        [Display(Name = "Biography")]
        public string Bio { get; set;}

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
