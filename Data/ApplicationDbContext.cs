using Microsoft.EntityFrameworkCore;
using ScholarshipManagement.Models;
using System.Collections.Generic;

namespace ScholarshipManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Scholarship> Scholarships { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}
