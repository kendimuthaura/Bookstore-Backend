using System.ComponentModel.DataAnnotations;

namespace BookStore__Management_system.Data
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string Status { get; set; }
    }
}
