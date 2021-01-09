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

        public virtual DbSet<ShoppingCard> CarritoCompras { get; set; }
        public virtual DbSet<Category> Categoria { get; set; }
        public virtual DbSet<Client> Cliente { get; set; }
        public virtual DbSet<OrderDetail> DetalleOrden { get; set; }
        public virtual DbSet<Addresss> Direccion { get; set; }
        public virtual DbSet<Employee> Empleado { get; set; }
        public virtual DbSet<ImageProduct> ImageProductos { get; set; }
        public virtual DbSet<PaymentMethod> MetodoDePago { get; set; }
        public virtual DbSet<OrdenProducto> OrdenProducto { get; set; }
        public virtual DbSet<Product> Producto { get; set; }
        public virtual DbSet<Provider> Proveedor { get; set; }
        public virtual DbSet<Province> Provincia { get; set; }
        public virtual DbSet<RolEmployee> RolEmpleado { get; set; }
        public virtual DbSet<Telephone> Telefono { get; set; }

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
            modelBuilder.Entity<ShoppingCard>(entity =>
            {
                entity.HasKey(e => e.IdCart);

                entity.HasOne(d => d.client)
                    .WithMany(p => p.ShoppingCart)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarritoCompras_Cliente");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCart)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarritoCompras_Producto");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("Pk_IdCategoria");

                entity.Property(e => e.NameProduct)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("Pk_IdCliente");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IdProvince).HasColumnName("Id_Provincia");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.IdProvince)
                    .HasConstraintName("Fk_Id_Provincia");

                entity.HasOne(d => d.SmartPhone)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.IdSmartPhone)
                    .HasConstraintName("Fk_IdSmartPhone");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.OrdenProduct)
                    .WithMany(p => p.DetalleOrden)
                    .HasForeignKey(d => d.IdProductOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleOrden_OrdenProducto");

                entity.HasOne(d => d.ProductO)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.IdProductO)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetalleOrden_Producto");
            });

            modelBuilder.Entity<Addresss>(entity =>
            {
                entity.HasKey(e => e.IdAddress)
                    .HasName("Pk_IdDireccion");

                entity.Property(e => e.Neighborhood)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Surroundings)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationCard)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmployeeAddress)
                    .IsRequired()
                    .HasColumnName("IdDireccion_Empleado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdProvinceEmployee).HasColumnName("IdProvincia_Empleado");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImageProduct>(entity =>
            {
                entity.HasKey(e => e.IdImage);

                entity.Property(e => e.IdProductImage).HasColumnName("idProductoImagen");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductImage)
                    .WithMany(p => p.ImageProducts)
                    .HasForeignKey(d => d.IdProductImage)
                    .HasConstraintName("FK_ImageProductos_Producto");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasKey(e => e.IdPaymentMethod);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenProducto>(entity =>
            {
                entity.HasKey(e => e.IdOrden);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.IdClienteOrdenNavigation)
                    .WithMany(p => p.ProductOrder)
                    .HasForeignKey(d => d.IdClienteOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenProducto_Cliente");

                entity.HasOne(d => d.IdClienteOrden1)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.IdClienteOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenProducto_MetodoDePago");

                entity.HasOne(d => d.IdDireccionOrdenNavigation)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.IdDireccionOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenProducto_Direccion");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("Pk_IdProducto");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCategoryP).HasColumnName("idCategoriaP");

                entity.Property(e => e.IdProvider).HasColumnName("Id_Proveedor");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.CategoryP)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.IdCategoryP)
                    .HasConstraintName("Fk_IdCategoria");

                entity.HasOne(d => d.ProviderP)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.IdProvider)
                    .HasConstraintName("FK_Producto_Proveedor");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.IdProvider)
                    .HasName("Pk_IdProveedor");

                entity.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdAddress).HasColumnName("Id_Direccion");

                entity.Property(e => e.IdProvince).HasColumnName("Id_Provincia");

                entity.Property(e => e.IdTelephone).HasColumnName("Id_Telefono");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAddressN)
                    .WithMany(p => p.Provider)
                    .HasForeignKey(d => d.IdAddress)
                    .HasConstraintName("Fk_Id_Direccion");

                entity.HasOne(d => d.IdProvinceN)
                    .WithMany(p => p.Provider)
                    .HasForeignKey(d => d.IdProvince)
                    .HasConstraintName("Fk_IdProvincia");

                entity.HasOne(d => d.IdTelephoneN)
                    .WithMany(p => p.Provider)
                    .HasForeignKey(d => d.IdTelephone)
                    .HasConstraintName("Fk_IdTelefono");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.IdProvince)
                    .HasName("Pk_IdProvincia");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolEmployee>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("Pk_idRol");

                entity.ToTable("rolEmpleado");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.IdRolEmployee).HasColumnName("idRolEmpleado");

                entity.Property(e => e.Name)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolEmployeeN)
                    .WithMany(p => p.RolEmployee)
                    .HasForeignKey(d => d.IdRolEmployee)
                    .HasConstraintName("Fk_idRolEmpleado");
            });

            modelBuilder.Entity<Telephone>(entity =>
            {
                entity.HasKey(e => e.IdTelephone)
                    .HasName("Pk_IdTelefono");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

           // OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
