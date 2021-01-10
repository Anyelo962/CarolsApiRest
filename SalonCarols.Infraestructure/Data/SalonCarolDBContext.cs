using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SalonCarols.Core.entities;
using SalonCarols.Infraestructure.Data.Configuration;

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

        public virtual DbSet<ShoppingCart> CarritoCompras { get; set; }
        public virtual DbSet<Category> Categoria { get; set; }
        public virtual DbSet<Client> Cliente { get; set; }
        public virtual DbSet<OrderDetail> DetalleOrden { get; set; }
        public virtual DbSet<Addresss> Direccion { get; set; }
        public virtual DbSet<Employee> Empleado { get; set; }
        public virtual DbSet<ImageProduct> ImageProductos { get; set; }
        public virtual DbSet<PaymentMethod> MetodoDePago { get; set; }
        public virtual DbSet<OrderProduct> OrdenProducto { get; set; }
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
            modelBuilder.ApplyConfiguration(new ShoppingCartConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());
            modelBuilder.ApplyConfiguration(new OrderProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new TelephoneConfiguration());
           // OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
