using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class OrdenProducto
    {
        public OrdenProducto()
        {
            DetalleOrden = new HashSet<OrderDetail>();
        }

        public int IdOrden { get; set; }
        public int IdClienteOrden { get; set; }
        public int IdMetodoDePago { get; set; }
        public decimal Total { get; set; }
        public int IdDireccionOrden { get; set; }

        public virtual PaymentMethod IdClienteOrden1 { get; set; }
        public virtual Client IdClienteOrdenNavigation { get; set; }
        public virtual Addresss IdDireccionOrdenNavigation { get; set; }
        public virtual ICollection<OrderDetail> DetalleOrden { get; set; }
    }
}
