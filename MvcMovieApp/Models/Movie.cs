using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMovieApp.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage ="Title must be of minimum length 3 and maximum length 60")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required(ErrorMessage ="Genre is required")]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 500, ErrorMessage ="Price must be between 1 and 500")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "Rating must be string with max length 5")]
        [StringLength(10)]
        public string Rating { get; set; }
    }
    public class MvcMovieAppContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}