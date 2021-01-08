using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class OrdenProducto
    {
        public OrdenProducto()
        {
            DetalleOrden = new HashSet<DetalleOrden>();
        }

        public int IdOrden { get; set; }
        public int IdClienteOrden { get; set; }
        public int IdMetodoDePago { get; set; }
        public decimal Total { get; set; }
        public int IdDireccionOrden { get; set; }

        public virtual MetodoDePago IdClienteOrden1 { get; set; }
        public virtual Cliente IdClienteOrdenNavigation { get; set; }
        public virtual Direccion IdDireccionOrdenNavigation { get; set; }
        public virtual ICollection<DetalleOrden> DetalleOrden { get; set; }
    }
}
