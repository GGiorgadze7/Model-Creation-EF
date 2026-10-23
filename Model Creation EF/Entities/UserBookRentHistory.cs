using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_Creation_EF.Entities
{
    [Table("UserBookRentHistories")]
    public class UserBookRentHistory
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public string Note { get; set; } = string.Empty;
        public string RentStatus { get; set; } = string.Empty;

        public int UserId { get; set; }
        public int BookId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }


    }
}
