using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rental_Application.Dtos
{
    public class MovieDto
    {

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Movie Name")]

        public string MovieName { get; set; }

            

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 100)]
        public byte NumberInStock { get; set; }
    }
}