using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class DetalleOrden
    {
        public int Id { get; set; }
        public int IdOrdenProducto { get; set; }
        public int IdProductoO { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public virtual OrdenProducto IdOrdenProductoNavigation { get; set; }
        public virtual Producto IdProductoONavigation { get; set; }
    }
}
