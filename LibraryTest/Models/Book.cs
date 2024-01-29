using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryTest.Models
{
    public class Book
    {
        [Key] public int BookId { get; set; }
        [Required] public string Title { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")] public virtual Author Author { get; set; }
    }
}
