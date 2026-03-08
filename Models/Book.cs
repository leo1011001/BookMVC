using System.ComponentModel.DataAnnotations;

namespace BookMVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
    }
}
