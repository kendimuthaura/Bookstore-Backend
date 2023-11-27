using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore__Management_system.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required]
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string Status { get; set; }


    }
}