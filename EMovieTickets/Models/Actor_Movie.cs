using System.ComponentModel.DataAnnotations.Schema;

namespace EMovieTickets.Models
{
    public class Actor_Movie
    {
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("ActorId")]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
