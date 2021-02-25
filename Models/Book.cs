using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    //Class to create book objects
    public class Book
    {
        //Properties for each book
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$", ErrorMessage = "Please enter a valid ISBN")]
        public long ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Pages { get; set; }


    }
}
