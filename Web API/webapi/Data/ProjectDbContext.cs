using Microsoft.EntityFrameworkCore;
using webapi.Models.Entities;

namespace webapi.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options)//way to talk to our table in our DB
        {
        }
        public DbSet<student> student { get; set; }//interface to interact with our student table
        public DbSet<borrowing> borrowing { get; set; }//interface to interact with our borrowing table
        public DbSet<librarian> librarian { get; set; }//interface to interact with our librarian table
        public DbSet<book> book { get; set; }//interface to interact with our book table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // borrowing foreign-key
            modelBuilder.Entity<borrowing>()
                .HasOne<student>()
                .WithMany()
                .HasForeignKey(p => p.student_ID);

            modelBuilder.Entity<borrowing>()
                .HasOne<book>()
                .WithMany()
                .HasForeignKey(p => p.book_ID);

            modelBuilder.Entity<borrowing>()
                .HasOne<librarian>()
                .WithMany()
                .HasForeignKey(p => p.librarian_ID);
        }
    }
}
