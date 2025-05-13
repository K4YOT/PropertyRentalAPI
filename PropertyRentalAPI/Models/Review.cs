using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyRentalAPI.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Property")]
        public int PropertyId { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Booking")]
        public int BookingId { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [Range(1, 5)]
        public int? CleanlinessRating { get; set; }

        [Range(1, 5)]
        public int? ComfortRating { get; set; }

        [Range(1, 5)]
        public int? LocationRating { get; set; }

        [Range(1, 5)]
        public int? ValueRating { get; set; }

        public string Comment { get; set; }

        public string HostReply { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public Property Property { get; set; }
        public IUser User { get; set; }
        public Booking Booking { get; set; }
    }
}