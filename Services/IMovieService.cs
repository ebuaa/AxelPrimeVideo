using AxelPrimeVideo.Models.Entities;

namespace AxelPrimeVideo.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdAsync(Guid id);
        Task CreateMovieAsync(Movie movie);
        Task UpdateMovieAsync(Movie movie);
        Task DeleteMovieAsync(Guid id);
    }
}