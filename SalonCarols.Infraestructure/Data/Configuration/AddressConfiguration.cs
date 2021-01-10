using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Addresss>
    {
        public void Configure(EntityTypeBuilder<Addresss> builder)
        {
            builder.HasKey(e => e.IdAddress)
                     .HasName("Pk_IdDireccion");

            builder.Property(e => e.Neighborhood)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.Street)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.PostalCode)
                .HasMaxLength(8)
                .IsUnicode(false);

            builder.Property(e => e.Surroundings)
                .HasMaxLength(60)
                .IsUnicode(false);
        }
    }
}
