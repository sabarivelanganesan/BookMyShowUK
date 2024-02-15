using EMovieTickets.Data.Base;
using EMovieTickets.Data.ViewModels;
using EMovieTickets.Models;

namespace EMovieTickets.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropDownVM> GetNewMovieDropdownsvalues();
        Task AddNewMovieASync(NewMovieVM newMovie);
        Task UpdateMovieAsync(NewMovieVM newMovie);
    }
}
