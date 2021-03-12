using Dale.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dale.Infraestructure.Mappings
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.Id);
            
            builder.ToTable("Client");
            builder.Property(e => e.Id).HasColumnName("Id");
            builder.Property(e => e.IdentificationDocument).HasColumnName("IdentificationDocument");
            builder.Property(e => e.Name).HasColumnName("Name");
            builder.Property(e => e.LastName).HasColumnName("LastName");
            builder.Property(e => e.NumberPhone).HasColumnName("NumberPhone");
         
        }
    }
}
