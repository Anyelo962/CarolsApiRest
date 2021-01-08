using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Producto
    {
        public Producto()
        {
            CarritoCompras = new HashSet<CarritoCompras>();
            DetalleOrden = new HashSet<DetalleOrden>();
            ImageProductos = new HashSet<ImageProductos>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Total { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdCategoriaP { get; set; }

        public virtual Categoria IdCategoriaPNavigation { get; set; }
        public virtual Proveedor IdProveedorNavigation { get; set; }
        public virtual ICollection<CarritoCompras> CarritoCompras { get; set; }
        public virtual ICollection<DetalleOrden> DetalleOrden { get; set; }
        public virtual ICollection<ImageProductos> ImageProductos { get; set; }
    }
}
