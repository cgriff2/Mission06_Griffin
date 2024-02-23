using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mission06_Griffin.Models
{
    public class Movie
    {
        [Key]
        [Required] // Set MovieId as a primary key
        public int MovieId { get; set; }
        
        [ForeignKey("CategoryId")] // Connect to Category model (table)
        public int? CategoryId { get; set; }
        public Category? CategoryName { get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter a title")]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2024, ErrorMessage = "You must enter a year between 1888 and 2024. ")]
        public int Year { get; set; } = 1888;
        
        public string Director { get; set; }
        public string Rating { get; set; }

        [Required]
        public int Edited { get; set; } = 0;
        public string LentTo { get; set; }
        [Required]
        public int CopiedToPlex { get; set; } = 0;
        public string Notes { get; set; }

    }
}
