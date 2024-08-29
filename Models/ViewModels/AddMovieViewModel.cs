namespace AxelPrimeVideo.Models.ViewModels
{
    public class AddMovieViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile ImageFile { get; set; }
        public string ImagePath { get; set; } // Propriété pour le chemin de l'image
        public DateOnly ReleaseDate { get; set; }
    }
}