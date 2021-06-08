using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Introduction.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Gelieve een titel in te voeren")]
        public string Title { get; set; }
        
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Gelieve een beschrijving in te voeren")]
        public string Description { get; set; }

       
        public bool IsInTheaters { get; set; }

        [Range(0,10, ErrorMessage = "Score tussen de 0 en 10")]
        public double Rating { get; set; }
               
        public DateTime ReleaseDate { get; set; }
    }
}
