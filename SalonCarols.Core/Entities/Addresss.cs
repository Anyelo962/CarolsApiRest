using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Addresss
    {
        public Addresss()
        {
            OrderProduct = new HashSet<OrdenProducto>();
            Provider = new HashSet<Provider>();
        }

        public int IdAddress { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string Surroundings { get; set; }
        public string PostalCode { get; set; }

        public virtual ICollection<OrdenProducto> OrderProduct { get; set; }
        public virtual ICollection<Provider> Provider { get; set; }
    }
}
