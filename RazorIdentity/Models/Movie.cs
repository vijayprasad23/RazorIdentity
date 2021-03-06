using System.ComponentModel.DataAnnotations;

namespace RazorIdentity.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Producer { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }

    }
}
