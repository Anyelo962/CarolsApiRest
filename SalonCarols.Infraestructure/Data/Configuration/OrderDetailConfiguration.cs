using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Data.Configuration
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Property(e => e.Price).HasColumnType("money");

            builder.HasOne(d => d.OrdenProduct)
                .WithMany(p => p.DetalleOrden)
                .HasForeignKey(d => d.IdProductOrder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleOrden_OrdenProducto");

            builder.HasOne(d => d.ProductO)
                .WithMany(p => p.OrderDetail)
                .HasForeignKey(d => d.IdProductO)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleOrden_Producto");
        }
    }
}
