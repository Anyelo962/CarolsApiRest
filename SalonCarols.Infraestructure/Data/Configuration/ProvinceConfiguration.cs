using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasKey(e => e.IdProvince)
                   .HasName("Pk_IdProvincia");

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
