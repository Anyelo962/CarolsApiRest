using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(e => e.IdOrder);

            builder.Property(e => e.Total).HasColumnType("money");

            builder.HasOne(d => d.IdClienteOrdenNavigation)
                .WithMany(p => p.ProductOrder)
                .HasForeignKey(d => d.IdClientOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenProducto_Cliente");

            builder.HasOne(d => d.IdClienteOrden1)
                .WithMany(p => p.OrderProduct)
                .HasForeignKey(d => d.IdClientOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenProducto_MetodoDePago");

            builder.HasOne(d => d.IdDireccionOrdenNavigation)
                .WithMany(p => p.OrderProduct)
                .HasForeignKey(d => d.IdDireccionOrden)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenProducto_Direccion");
        }
    }
}
