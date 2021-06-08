using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Introduction.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Naam is verplicht")]
        public string Name { get; set; }
        
        [Range(1,1, ErrorMessage = "Enkel volwassen materiaal toegestaan")]
        public bool IsAdult { get; set; }
    }
}
