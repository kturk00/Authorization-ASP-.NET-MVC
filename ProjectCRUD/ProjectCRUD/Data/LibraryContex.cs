using Microsoft.EntityFrameworkCore;
using ProjectCRUD.Models;

namespace ProjectCRUD.Data
{
    public class LibraryContex : DbContext
    {
        public LibraryContex(DbContextOptions<LibraryContex> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author);
        }

    }
}
