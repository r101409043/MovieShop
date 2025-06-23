using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Services;

public class GenreService : IGenreService
{
    public async Task<IEnumerable<Genre>> GetAllGenres()
    {
        var genres = new List<Genre>
        {
            new Genre { Id = 1, Name = "Action" },
            new Genre { Id = 2, Name = "Comedy" },
            new Genre { Id = 3, Name = "Drama" },
        };
        return await Task.FromResult(genres);
    }
}