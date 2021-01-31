namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string DateAdded { get; set; }
        public int NumberInStock { get; set; }
        public MovieGenre MovieGenre { get; set; }
        public byte MovieGenreId { get; set; }
    }
}