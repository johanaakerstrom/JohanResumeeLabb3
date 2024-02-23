using JohanResumeeLabb3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JohanResumeeLabb3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<About> About { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Projects> Projects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

    }
}
