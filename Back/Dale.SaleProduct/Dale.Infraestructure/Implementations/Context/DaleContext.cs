using Dale.Domain;
using Dale.Infraestructure.Definitions.Context;
using Dale.Infraestructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Dale.Infraestructure.Implementations.Context
{
    internal class DaleContext : DbContext, IDaleContext
    {  
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMapping());
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new BillMapping());
            modelBuilder.ApplyConfiguration(new BillDetailMapping());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=BG-D-CCARVAJAL1;Database=Dale;User ID=admuser;Password=Aranda2019");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
