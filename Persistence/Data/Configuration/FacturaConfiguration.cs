using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
{
    public void Configure(EntityTypeBuilder<Factura> builder)
    {
        builder.ToTable("factura");

        builder.HasKey(x=>x.Id);

        builder.Property(x=>x.FacturaInicial).HasColumnType("int");
        builder.Property(x=>x.FacturaFinal).HasColumnType("int");
        builder.Property(x=>x.FacturaActual).HasColumnType("int");
        builder.Property(x=>x.NroResolucion).IsRequired().HasMaxLength(10);
    }
}
