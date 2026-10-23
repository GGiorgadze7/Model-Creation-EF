using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_Creation_EF.Entities
{
    [Table("UserFavoriteBooks")]
    public class UserFavoriteBook
    {
        [Key]
        public int Id { get; set; }

        public DateTime AddDate { get; set; } = DateTime.Now;
        public string Comment { get; set; }
        public int? Rate { get; set; }
        public string BookReadStatus { get; set; }
        public DateTime? ReadEndTime { get; set; }

        public int UserId { get; set; }
        public int BookId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book Book { get; set; }

    }
}
