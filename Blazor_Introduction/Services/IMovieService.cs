using Blazor_Introduction.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor_Introduction.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetMoviesAsync();
    }
}