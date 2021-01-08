using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class CarritoCompras
    {
        public int IdCarrito { get; set; }
        public int IdProducto { get; set; }
        public int IdCliente { get; set; }
        public int Cantidad { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
