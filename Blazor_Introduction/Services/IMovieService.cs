using Blazor_Introduction.Models;
using System.Collections.Generic;

namespace Blazor_Introduction.Services
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
    }
}