using EMovieTickets.Data.Base;
using EMovieTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace EMovieTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base (context) { }
    }
}
