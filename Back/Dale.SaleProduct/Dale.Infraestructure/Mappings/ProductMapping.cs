using Dale.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dale.Infraestructure.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("Product");
            builder.Property(e => e.Id).HasColumnName("Id");      
            builder.Property(e => e.Name).HasColumnName("Name");
            builder.Property(e => e.Cost).HasColumnName("Cost");
        }
    }
}