using Blazor_Introduction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Introduction.Services
{
    public class GenreService : IGenreService
    {
        private List<Genre> genres = new List<Genre>
        {
            new Genre{Id = 1, Name="Action", IsAdult=false},
            new Genre{Id = 2, Name="Adventure", IsAdult=false},
            new Genre{Id = 3, Name="Family", IsAdult=false},
            new Genre{Id = 4, Name="Thriller", IsAdult=true},
            new Genre{Id = 5, Name="Horror", IsAdult=true},
        };

        public List<Genre> GetGenres()
        {
            return genres;
        }

        public void AddGenre(Genre genre)
        {
            genres.Add(genre);
        }

        public void EditGenre(Genre genre)
        {
            var oldGenre = genres.FirstOrDefault(x => x.Id == genre.Id);
            oldGenre = genre;
        }

        public void DeleteGenre(Genre genre)
        {
            genres.Remove(genre);
        }
    }
}
