using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectCRUD.Validators;

namespace ProjectCRUD.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [StringLength(30, MinimumLength = 2)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(30, MinimumLength = 2)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [CodeValidator]
        public string Code { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
