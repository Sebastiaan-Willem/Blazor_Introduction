using Blazor_Introduction.Models;
using System.Collections.Generic;

namespace Blazor_Introduction.Services
{
    public interface IGenreService
    {
        void AddGenre(Genre genre);
        void DeleteGenre(Genre genre);
        void EditGenre(Genre genre);
        List<Genre> GetGenres();
    }
}