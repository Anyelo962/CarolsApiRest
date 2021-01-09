using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            OrderProduct = new HashSet<OrdenProducto>();
        }

        public int IdPaymentMethod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrdenProducto> OrderProduct { get; set; }
    }
}
