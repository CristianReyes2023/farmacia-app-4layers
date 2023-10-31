using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class FormatoPagoConfigurate : IEntityTypeConfiguration<FormaPago>
{
    public void Configure(EntityTypeBuilder<FormaPago> builder)
    {
        builder.ToTable("formatopago");

        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.NombreFormaPago).IsRequired().HasMaxLength(50);
    }
}
