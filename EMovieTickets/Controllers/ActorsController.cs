using EMovieTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMovieTickets.Controllers
{
    public class ActorsController : Controller
    {
         private readonly AppDbContext _context;
         public ActorsController(AppDbContext context)
         {
             _context = context;
         }
        public IActionResult Index()
        {
            var allActors = _context.Actors.ToList();
            return View(allActors);
        }
    }
}
