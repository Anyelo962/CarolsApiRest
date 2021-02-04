using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
             builder.HasKey(e => e.IdCategory)
                    .HasName("Pk_IdCategoria");
            builder.Property(e => e.IdCategory)
                .HasColumnName("IdCategoria");
                   // .ValueGeneratedNever();

                builder.Property(e => e.NameProduct)
                    .HasColumnName("Nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);
        }
    }
}
