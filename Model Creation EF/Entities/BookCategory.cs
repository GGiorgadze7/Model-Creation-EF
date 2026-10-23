using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_Creation_EF.Entities
{

    [Table("BookCategories")]
    public class BookCategory
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Genre { get; set; } 

        public ICollection<Book> Books { get; set; } = new List<Book>();


    }
}
