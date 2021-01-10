using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.HasKey(e => e.IdCart);

            builder.HasOne(d => d.client)
                .WithMany(p => p.ShoppingCart)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CarritoCompras_Cliente");

            builder.HasOne(d => d.Product)
                .WithMany(p => p.ShoppingCart)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CarritoCompras_Producto");
        }
    }
}
