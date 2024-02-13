using EMovieTickets.Data.Base;
using EMovieTickets.Models;

namespace EMovieTickets.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
