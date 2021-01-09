using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class OrderProduct
    {
        public OrderProduct()
        {
            OrderDetailN = new HashSet<OrderDetail>();
        }

        public int IdOrder { get; set; }
        public int IdClientOrder { get; set; }
        public int IdPayMethod { get; set; }
        public decimal Total { get; set; }
        public int IdAddressOrder { get; set; }

        public virtual PaymentMethod PaymentMethodClient { get; set; }
        public virtual Client IdClientOrderN { get; set; }
        public virtual Addresss IdAddressOrderN { get; set; }
        public virtual ICollection<OrderDetail> OrderDetailN { get; set; }
    }
}
