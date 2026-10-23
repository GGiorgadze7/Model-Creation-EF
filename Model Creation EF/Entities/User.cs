using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_Creation_EF.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime? LastAccessTime { get; set; }
        public DateTime Birthdate { get; set; }
        public string UserName { get; set; } 
        public string Password { get; set; }

        public ICollection<BookReview> BookReviews { get; set; } = new List<BookReview>();
        public ICollection<UserFavoriteBook> UserFavoriteBooks { get; set; } = new List<UserFavoriteBook>();
        public ICollection<UserBookRentHistory> userBookRentHistories { get; set; } = new List<UserBookRentHistory>();

    }
}
