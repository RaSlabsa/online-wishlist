using Microsoft.EntityFrameworkCore;
using WishList.Domain.Entities;

namespace WishList.Infrastructure.Persistence
{
    public class WishListDb : DbContext
    {
        public WishListDb(DbContextOptions<WishListDb> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.Requester)
                .WithMany()
                .HasForeignKey(f => f.RequesterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.Receiver)
                .WithMany()
                .HasForeignKey(f => f.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        DbSet<User> Users { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<UserWishList> WishLists { get; set; }
        DbSet<Friendship> Friendships { get; set; }
    }
}
