using AxelPrimeVideo.Data;
using AxelPrimeVideo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AxelPrimeVideo.Services
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(Guid id)
        {
            return await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task CreateMovieAsync(Movie movie)
        {
            movie.Id = Guid.NewGuid();
            _context.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMovieAsync(Movie movie)
        {
            _context.Update(movie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMovieAsync(Guid id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }
    }
}