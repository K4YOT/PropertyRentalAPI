using Microsoft.EntityFrameworkCore;

namespace PropertyRentalAPI.Models
{
    public class PropertyRentalContext : DbContext
    {
        public PropertyRentalContext(DbContextOptions<PropertyRentalContext> options)
            : base(options)
        {
        }

        public DbSet<IUser> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IUser>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Review>()
                .HasIndex(r => r.BookingId)
                .IsUnique();
        }
    }
}