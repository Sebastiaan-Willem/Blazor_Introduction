using Blazor_Introduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Introduction.Services
{
    public class MovieService : IMovieService
    {
        private IGenreService _genreService;
        private List<Genre> genres;
        public MovieService(IGenreService service)
        {
            _genreService = service;
            genres = _genreService.GetGenres();
        }
        //OnInitialized() -> similar to OnAwake function in unity
        //seed list with dummy data
        public async Task<List<Movie>> GetMoviesAsync()
        {
            //simulate loading data
           //await Task.Delay(3000);

            return new List<Movie>
            {
                new Movie{Title = "Titanic", IsInTheaters = true, GenreId = 0 , Rating=8.4, ReleaseDate = new DateTime(1999,01,01) },
                new Movie{Title = "Joker", IsInTheaters = true, Genre= genres[4] , Rating=8.1, ReleaseDate = new DateTime(2019,01,01)},
                new Movie { Title = "Ghost Ship", IsInTheaters = true, Genre= genres[3] , Rating = 5.7, ReleaseDate = new DateTime(2004,01,01) },
            };
        }

    }
}
