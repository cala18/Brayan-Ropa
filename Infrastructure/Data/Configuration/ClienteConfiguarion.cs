using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ClienteConfiguarion : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Cliente");

        builder.HasKey(x => x.ClienteId);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreCliente).HasMaxLength(50);
        builder.HasOne(x => x.Municipio).WithMany(x => x.Cliente).HasForeignKey(x=>x.Cliente);
    }
}
