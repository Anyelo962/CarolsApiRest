using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.IdProduct)
                    .HasName("Pk_IdProducto");

            builder.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.IdCategoryP).HasColumnName("idCategoriaP");

            builder.Property(e => e.IdProvider).HasColumnName("Id_Proveedor");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Price).HasColumnType("money");

            builder.Property(e => e.Total).HasColumnType("money");

            builder.HasOne(d => d.CategoryP)
                .WithMany(p => p.Product)
                .HasForeignKey(d => d.IdCategoryP)
                .HasConstraintName("Fk_IdCategoria");

            builder.HasOne(d => d.ProviderP)
                .WithMany(p => p.Product)
                .HasForeignKey(d => d.IdProvider)
                .HasConstraintName("FK_Producto_Proveedor");
        }
    }
}
