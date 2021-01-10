using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.IdEmployee);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.IdentificationCard)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.IdEmployeeAddress)
                .IsRequired()
                .HasColumnName("IdDireccion_Empleado")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.IdProvinceEmployee).HasColumnName("IdProvincia_Empleado");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
