using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }

        public string DateAdded { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 10)]
        public int NumberInStock { get; set; }

        public MovieGenre MovieGenre { get; set; }

        [Display(Name = "Genre")]
        public byte MovieGenreId { get; set; }

        public byte NumberAvailable { get; set; }
    }
}