using Microsoft.EntityFrameworkCore;
using MuseumData.Models;

namespace MuseumData
{
    public class MuseumContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .HasKey(s => new {s.OrderId, s.TicketId});
        }

        public MuseumContext(DbContextOptions<MuseumContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ClosedDay> ClosedDays { get; set; }
        public DbSet<Doll> Dolls { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Promocode> Promocodes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}