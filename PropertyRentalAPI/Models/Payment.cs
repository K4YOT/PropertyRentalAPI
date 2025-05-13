using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyRentalAPI.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Booking")]
        public int BookingId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(20)]
        public string PaymentMethod { get; set; } 

        [StringLength(100)]
        public string TransactionId { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } 

        public DateTime? PaymentDate { get; set; }

        [StringLength(255)]
        public string ReceiptUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public Booking Booking { get; set; }
    }
}