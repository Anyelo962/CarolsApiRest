using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class RolEmployeeConfiguration : IEntityTypeConfiguration<RolEmployee>
    {
        public void Configure(EntityTypeBuilder<RolEmployee> builder)
        {
            builder.ToTable("rolEmpleado");

            builder.HasKey(e => e.IdRol)
                      .HasName("Pk_idRol");

            builder.Property(e => e.IdRol).
                 HasColumnName("idRol")
                .ValueGeneratedNever();

            builder.Property(e => e.Name)
                .HasColumnName("nombre")
                .HasMaxLength(30)
                .IsUnicode(false);

                builder.Property(e => e.IdRolEmployee).
                     HasColumnName("idRolEmpleado");
            builder.HasOne(d => d.IdRolEmployeeN)
                .WithMany(p => p.RolEmployee)
                .HasForeignKey(d => d.IdRolEmployee)
                .HasConstraintName("Fk_idRolEmpleado");
        }
    }
}
