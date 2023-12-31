using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class MovimientoInventarioConfiguration : IEntityTypeConfiguration<MovimientoInventario>
{
    public void Configure(EntityTypeBuilder<MovimientoInventario> builder)
    {
        builder.ToTable("movimientoinventario");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Id).HasMaxLength(10);

        builder.Property(x=>x.FechaMovimiento).HasColumnType("date");
        builder.Property(x=>x.FechaVencimiento).HasColumnType("date");

        builder.HasOne(x=>x.FormaPagos).WithMany(x=>x.MovimientoInventarios).HasForeignKey(x=>x.IdFormaPagoFk);
        builder.HasOne(x=>x.PersonaResponsable).WithMany(x=>x.MovimientoInventarios).HasForeignKey(x=>x.IdResponsableFk);
        // builder.HasOne(x=>x.PersonaReceptor).WithMany(x=>x.MovimientoInventarios).HasForeignKey(x=>x.IdReceptor);
        builder.HasOne(x=>x.TipoMovInventarios).WithMany(x=>x.MovimientoInventarios).HasForeignKey(x=>x.IdTipoMovInvFk);
        builder.HasOne(x=>x.Facturas).WithMany(x=>x.MovimientoInventarios).HasForeignKey(x=>x.IdFacturaFk);    
    }
}
