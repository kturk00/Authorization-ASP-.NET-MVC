using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCRUD.Validators;

namespace ProjectCRUD.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int AuthorID { get; set; }
        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Title { get; set; }
        [CustomDateValidator]
        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Author Author { get; set; }
    }
}
