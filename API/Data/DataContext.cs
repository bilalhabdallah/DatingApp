using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppEmployee> Tbl_Employee { get; set; }

        public DbSet<view_employee> Vw_Employee { get; set; }
        public DbSet<Tbl_Country> Tbl_Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<view_employee>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("Vw_Employee");
            });
        }



    }
}