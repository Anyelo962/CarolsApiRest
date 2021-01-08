using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SalonCarols.Core.entities;
namespace SalonCarols.Infraestructure.Data
{
    public partial class SalonCarolDBContext : DbContext
    {
        public SalonCarolDBContext()
        {
        }

        public SalonCarolDBContext(DbContextOptions<SalonCarolDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CarritoCompras> CarritoCompras { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetalleOrden> DetalleOrden { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<ImageProductos> ImageProductos { get; set; }
        public virtual DbSet<MetodoDePago> MetodoDePago { get; set; }
        public virtual DbSet<OrdenProducto> OrdenProducto { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<RolEmpleado> RolEmpleado { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-0BP9LLN;Database=SalonCarolDB;Integrated Security = true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarritoCompras>(entity =>
            {
                entity.HasKey(e => e.IdCarrito);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CarritoCompras)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarritoCompras_Cliente");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CarritoCompras)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarritoCompras_Producto");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("Pk_IdCategoria");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("Pk_IdCliente");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.IdProvincia).HasColumnName("Id_Provincia");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("Fk_Id_Provincia");

                entity.HasOne(d => d.IdSmartPhoneNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdSmartPhone)
                    .HasConstraintName("Fk_IdSmartPhone");
            });

            modelBuilder.Entity<DetalleOrden>(entity =>
            {
                entity.Property(e => e.Precio).HasColumnType("money");

                entity.HasOne(d => d.IdOrdenProductoNavigation)
                    .WithMany(p => p.DetalleOrden)
                    .HasForeignKey(d => d.IdOrdenProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleOrden_OrdenProducto");

                entity.HasOne(d => d.IdProductoONavigation)
                    .WithMany(p => p.DetalleOrden)
                    .HasForeignKey(d => d.IdProductoO)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleOrden_Producto");
            });

            modelBuilder.Entity<Direccion>(entity =>
            {
                entity.HasKey(e => e.IdDireccion)
                    .HasName("Pk_IdDireccion");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdDireccionEmpleado)
                    .IsRequired()
                    .HasColumnName("IdDireccion_Empleado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvinciaEmpleado).HasColumnName("IdProvincia_Empleado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImageProductos>(entity =>
            {
                entity.HasKey(e => e.IdImage);

                entity.Property(e => e.IdProductoImagen).HasColumnName("idProductoImagen");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProductoImagenNavigation)
                    .WithMany(p => p.ImageProductos)
                    .HasForeignKey(d => d.IdProductoImagen)
                    .HasConstraintName("FK_ImageProductos_Producto");
            });

            modelBuilder.Entity<MetodoDePago>(entity =>
            {
                entity.HasKey(e => e.IdMetodoPago);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenProducto>(entity =>
            {
                entity.HasKey(e => e.IdOrden);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.IdClienteOrdenNavigation)
                    .WithMany(p => p.OrdenProducto)
                    .HasForeignKey(d => d.IdClienteOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenProducto_Cliente");

                entity.HasOne(d => d.IdClienteOrden1)
                    .WithMany(p => p.OrdenProducto)
                    .HasForeignKey(d => d.IdClienteOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenProducto_MetodoDePago");

                entity.HasOne(d => d.IdDireccionOrdenNavigation)
                    .WithMany(p => p.OrdenProducto)
                    .HasForeignKey(d => d.IdDireccionOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenProducto_Direccion");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("Pk_IdProducto");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCategoriaP).HasColumnName("idCategoriaP");

                entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.IdCategoriaPNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdCategoriaP)
                    .HasConstraintName("Fk_IdCategoria");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdProveedor)
                    .HasConstraintName("FK_Producto_Proveedor");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("Pk_IdProveedor");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDireccion).HasColumnName("Id_Direccion");

                entity.Property(e => e.IdProvincia).HasColumnName("Id_Provincia");

                entity.Property(e => e.IdTelefono).HasColumnName("Id_Telefono");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDireccionNavigation)
                    .WithMany(p => p.Proveedor)
                    .HasForeignKey(d => d.IdDireccion)
                    .HasConstraintName("Fk_Id_Direccion");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Proveedor)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("Fk_IdProvincia");

                entity.HasOne(d => d.IdTelefonoNavigation)
                    .WithMany(p => p.Proveedor)
                    .HasForeignKey(d => d.IdTelefono)
                    .HasConstraintName("Fk_IdTelefono");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.IdProvincia)
                    .HasName("Pk_IdProvincia");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("Pk_idRol");

                entity.ToTable("rolEmpleado");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.IdRolEmpleado).HasColumnName("idRolEmpleado");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolEmpleadoNavigation)
                    .WithMany(p => p.RolEmpleado)
                    .HasForeignKey(d => d.IdRolEmpleado)
                    .HasConstraintName("Fk_idRolEmpleado");
            });

            modelBuilder.Entity<Telefono>(entity =>
            {
                entity.HasKey(e => e.IdTelefono)
                    .HasName("Pk_IdTelefono");

                entity.Property(e => e.NumeroTelefonico)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

           // OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
