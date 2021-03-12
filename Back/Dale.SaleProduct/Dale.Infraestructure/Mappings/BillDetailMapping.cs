using System;
using System.Collections.Generic;
using System.Text;
using Dale.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dale.Infraestructure.Mappings
{
    public class BillDetailMapping : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.HasKey(e => e.Id);
            builder.ToTable("BillDetail");
            builder.Property(e => e.Id).HasColumnName("Id");
            builder.Property(e => e.Ammount).HasColumnName("Ammount");
            builder.Property(e => e.BillId).HasColumnName("BillId");
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
        }
    }
}