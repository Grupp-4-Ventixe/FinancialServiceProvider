using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancialService.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TransactionEntity> Transactions { get; set; }
        public DbSet<StatusEntity> Statuses { get; set; }
        public DbSet<TransactionTypeEntity> TransactionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusEntity>().HasData(
                new StatusEntity { StatusId = 1, Name = "Completed", Description = "The transaction has been completed." },
                new StatusEntity { StatusId = 2, Name = "Pending", Description = "The transaction is pending approval or processing." }
            );

            modelBuilder.Entity<TransactionTypeEntity>().HasData(
                new TransactionTypeEntity { TransactionTypeId = 1, Name = "Income", Description = "Represents money received." },
                new TransactionTypeEntity { TransactionTypeId = 2, Name = "Expense", Description = "Represents money spent." }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
