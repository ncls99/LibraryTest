using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryTest.Models
{
    public class Author
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int AuthorId {  get; set; }
        [Required]public string Name { get; set; }

        public virtual List<Book> BookList { get; set;}
    }
}
