using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_Creation_EF.Entities
{
    [Table("BooksReviews")]
    public class BookReview
    {
        [Key]
        public int Id { get; set; }

        public int Star { get; set; }
        public string Comment { get; set; }

        public int BookId { get; set; }
        public int UserId { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

    }
}
