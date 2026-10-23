using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_Creation_EF.Entities
{
    [Table("Authors")]
    public  class Author
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; } 
        public string Phone { get; set; } 
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();


    }
}
