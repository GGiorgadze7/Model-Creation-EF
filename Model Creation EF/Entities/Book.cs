using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Identity.Client.AuthScheme.PoP;

namespace Model_Creation_EF.Entities
{

    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public string Description { get; set; } 
        public DateTime ReleaseDate { get; set; }
        public int ChapterCount { get; set; }
        public string Genre { get; set; }
        public string Releaser { get; set; }
        public int BookCount { get; set; }

        public int AuthorId { get; set; }
        public int BookCategoryId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }

        [ForeignKey(nameof(BookCategoryId))]
        public BookCategory BookCategory { get; set; }

        public ICollection<BookReview> BookReviews { get; set; } = new List<BookReview>();
        public ICollection<UserFavoriteBook> UserFavoriteBooks { get; set; } = new List<UserFavoriteBook>();
        public ICollection<UserBookRentHistory> userBookRentHistories { get; set; } = new List<UserBookRentHistory>();

    }
}
