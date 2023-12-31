using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.ToTable("producto");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Id).HasMaxLength(50);

        builder.Property(x=>x.NombreProducto).IsRequired().HasMaxLength(50);

        builder.HasOne(x=>x.Marcas).WithMany(x=>x.Productos).HasForeignKey(x=>x.IdMarcaFk);
    }
}
