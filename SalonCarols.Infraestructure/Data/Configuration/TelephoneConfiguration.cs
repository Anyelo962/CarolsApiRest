using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class TelephoneConfiguration : IEntityTypeConfiguration<Telephone>
    {
        public void Configure(EntityTypeBuilder<Telephone> builder)
        {
            builder.HasKey(e => e.IdTelephone)
                     .HasName("Pk_IdTelefono");

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(14)
                .IsUnicode(false);

            builder.Property(e => e.CellPhone)
                .HasMaxLength(14)
                .IsUnicode(false);
        }
    }
}
