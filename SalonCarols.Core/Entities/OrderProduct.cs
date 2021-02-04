using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class OrderProduct
    {
        public OrderProduct()
        {
            DetalleOrden = new HashSet<OrderDetail>();
        }

        public int IdOrder { get; set; }
        public int IdClientOrder { get; set; }
        public int IdPayMethod { get; set; }
        public decimal Total { get; set; }
        public int IdDireccionOrden { get; set; }

        public virtual PaymentMethod IdClienteOrden1 { get; set; }
        public virtual Client IdClienteOrdenNavigation { get; set; }
        public virtual Addresss IdDireccionOrdenNavigation { get; set; }
        public virtual ICollection<OrderDetail> DetalleOrden { get; set; }
    }
}
