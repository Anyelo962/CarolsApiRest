using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class ImageConfiguration : IEntityTypeConfiguration<ImageProduct>
    {
        public void Configure(EntityTypeBuilder<ImageProduct> builder)
        {
            builder.HasKey(e => e.IdImage);

            builder.Property(e => e.IdProductImage).HasColumnName("idProductoImagen");

            builder.Property(e => e.Image)
                .HasColumnName("image")
                .IsUnicode(false);

            builder.HasOne(d => d.ProductImage)
                .WithMany(p => p.ImageProducts)
                .HasForeignKey(d => d.IdProductImage)
                .HasConstraintName("FK_ImageProductos_Producto");
        }
    }
}
