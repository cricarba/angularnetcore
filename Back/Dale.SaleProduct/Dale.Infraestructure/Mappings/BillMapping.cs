using System;
using System.Collections.Generic;
using System.Text;
using Dale.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dale.Infraestructure.Mappings
{
    public class BillMapping : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("Bill");
            builder.Property(e => e.Id).HasColumnName("Id");
            builder.Property(e => e.Client).HasColumnName("ClientId");           
            builder.Property(e => e.Serial).HasColumnName("Serial");
            builder.Property(e => e.TotalAmmount).HasColumnName("TotalAmmount");

        }
    }
}
