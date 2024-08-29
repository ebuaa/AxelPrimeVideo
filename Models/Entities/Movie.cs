using System.ComponentModel.DataAnnotations.Schema;

namespace AxelPrimeVideo.Models.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}