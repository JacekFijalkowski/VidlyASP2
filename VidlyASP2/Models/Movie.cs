using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidlyASP2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Range(1,20)]
        [Display(Name = "Number in Stock")]
        public int InStock { get; set; }

        public Movie()
        {
            Id = 0;
            ReleaseDate = DateTime.Today;
        }

    }
}