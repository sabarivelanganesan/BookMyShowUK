using EMovieTickets.Data.Base;
using EMovieTickets.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMovieTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [Display(Name = "Price in £")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is Required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie Start date")]
        [Required(ErrorMessage = "Movie Start date is Required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie End date")]
        [Required(ErrorMessage = "Movie End date is Required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Movie Category")]
        [Required(ErrorMessage = "Movie Category is Required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Select actors(s)")]
        [Required(ErrorMessage = "Movie actor(s) is Required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select Cinema(s)")]
        [Required(ErrorMessage = "Movie Cinema(s) is Required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select producer(s)")]
        [Required(ErrorMessage = "Movie producer(s) is Required")]
        public int ProducerId { get; set; }
    }
}
