using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.IdClient)
                   .HasName("Pk_IdCliente");

            builder.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.CreationDate).HasColumnType("datetime");

            builder.Property(e => e.IdProvince).HasColumnName("Id_Provincia");

            builder.Property(e => e.Name)
                .HasMaxLength(32)
                .IsUnicode(false);

            builder.Property(e => e.Sex)
                .HasMaxLength(12)
                .IsUnicode(false);

            builder.HasOne(d => d.Province)
                .WithMany(p => p.Client)
                .HasForeignKey(d => d.IdProvince)
                .HasConstraintName("Fk_Id_Provincia");

            builder.HasOne(d => d.SmartPhone)
                .WithMany(p => p.Client)
                .HasForeignKey(d => d.IdSmartPhone)
                .HasConstraintName("Fk_IdSmartPhone");
        }
    }
}
