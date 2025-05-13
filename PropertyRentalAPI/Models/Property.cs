using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyRentalAPI.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(20)]
        public string PropertyType { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PricePerNight { get; set; }

        [Required]
        public int Bedrooms { get; set; }

        [Required]
        public int Bathrooms { get; set; }

        [Required]
        public int MaxGuests { get; set; }

        public int? SquareMeters { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("User")]
        public int UserId { get; set; }

        public IUser User { get; set; }
    }
}