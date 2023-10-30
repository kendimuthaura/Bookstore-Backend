using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore__Management_system.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required]
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Availability { get; set; }


    }
}