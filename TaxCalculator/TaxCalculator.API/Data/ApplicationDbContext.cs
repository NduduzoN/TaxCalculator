using Microsoft.EntityFrameworkCore;
using TaxCalculator.API.Models;

namespace TaxCalculator.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        public DbSet<FlatValue> FlatValue { get; set; }
        public DbSet<FlatRate> FlatRate { get; set; }
        public DbSet<ProgressiveTax> ProgressiveTax { get; set; }
        public DbSet<PostalCodes> PostalCode { get; set; }
        public DbSet<CalculationLog> CalculationLog { get; set; }

    }
}
