using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(e => e.IdProvider)
                   .HasName("Pk_IdProveedor");

            builder.Property(e => e.LastName)
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.IdAddress).HasColumnName("Id_Direccion");

            builder.Property(e => e.IdProvince).HasColumnName("Id_Provincia");

            builder.Property(e => e.IdTelephone).HasColumnName("Id_Telefono");

            builder.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);

            builder.Property(e => e.Sex)
                .HasMaxLength(12)
                .IsUnicode(false);

            builder.HasOne(d => d.IdAddressN)
                .WithMany(p => p.Provider)
                .HasForeignKey(d => d.IdAddress)
                .HasConstraintName("Fk_Id_Direccion");

            builder.HasOne(d => d.IdProvinceN)
                .WithMany(p => p.Provider)
                .HasForeignKey(d => d.IdProvince)
                .HasConstraintName("Fk_IdProvincia");

            builder.HasOne(d => d.IdTelephoneN)
                .WithMany(p => p.Provider)
                .HasForeignKey(d => d.IdTelephone)
                .HasConstraintName("Fk_IdTelefono");
        }
    }
}
