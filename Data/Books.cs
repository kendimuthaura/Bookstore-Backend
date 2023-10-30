using System.ComponentModel.DataAnnotations;

namespace BookStore__Management_system.Data
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Availability { get; set; }
    }
}
