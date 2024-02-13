using EMovieTickets.Data.Base;
using EMovieTickets.Models;

namespace EMovieTickets.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
