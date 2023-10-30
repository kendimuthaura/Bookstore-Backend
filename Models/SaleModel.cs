﻿using BookStore__Management_system.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore__Management_system.Models
{
    public class SaleModel
    { 
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public DateTime SaleDate { get; set; }

    [Required]
    [ForeignKey(nameof(Books.Id))]
    public int BookId { get; set; }


    [Required]
    [Range(1, int.MaxValue)]
    public int TotalPrice { get; set; }
    }
}