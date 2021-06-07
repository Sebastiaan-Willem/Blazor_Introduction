using Blazor_Introduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Introduction.Services
{
    public class MovieService : IMovieService
    {
        //OnInitialized() -> similar to OnAwake function in unity
        //seed list with dummy data
        public async Task<List<Movie>> GetMoviesAsync()
        {
            //simulate loading data
           //await Task.Delay(3000);

            return new List<Movie>
            {
                new Movie{Title = "Titanic", Genre="Drama", Rating=8.4, YearOfRelease=1999},
                new Movie{Title = "Joker", Genre="Drama", Rating=8.1, YearOfRelease=2019},
                new Movie { Title = "Ghost Ship", Genre = "Horror", Rating = 5.7, YearOfRelease = 2004 },
            };
        }

    }
}
