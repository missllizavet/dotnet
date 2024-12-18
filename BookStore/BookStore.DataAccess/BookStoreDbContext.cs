using Microsoft.EntityFrameworkCore;
using BookStore.DataAccess.Entities;

namespace BookStore.DataAccess;
public class BookStoreDbContext : DbContext
{           
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<AdminEntity> Admins { get; set; }
    public DbSet<ReaderEntity> Readers { get; set; }
    public DbSet<AuthorEntity> Authors { get; set; }
    public DbSet<BookEntity> Books { get; set; }
    public DbSet<GenreEntity> Genres { get; set; }
    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<OrderItemEntity> OrderItems { get; set; } // Исправлено имя

    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
    {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<ReaderEntity>().HasBaseType<UserEntity>();
        modelBuilder.Entity<AdminEntity>().HasBaseType<UserEntity>();

        modelBuilder.Entity<OrderEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<OrderEntity>().HasOne(x => x.User)
            .WithMany(u => u.Orders) // Добавлено навигационное свойство
            .HasForeignKey(x => x.UserId);
        modelBuilder.Entity<OrderEntity>().HasMany(x => x.OrderItems) // Добавлено навигационное свойство
            .WithOne(x => x.Order)
            .HasForeignKey(x => x.OrderId);

        modelBuilder.Entity<OrderItemEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<OrderItemEntity>().HasOne(x => x.Book)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.BookId);


        modelBuilder.Entity<BookEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<BookEntity>().HasOne(x => x.Author)
            .WithMany(a => a.Books) // Добавлено навигационное свойство
            .HasForeignKey(x => x.AuthorId);

        modelBuilder.Entity<BookEntity>().HasOne(x => x.Genre)
            .WithMany(g => g.Books) // Добавлено навигационное свойство
            .HasForeignKey(x => x.GenreId);

        modelBuilder.Entity<AuthorEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<GenreEntity>().HasKey(x => x.Id);
    }
}
