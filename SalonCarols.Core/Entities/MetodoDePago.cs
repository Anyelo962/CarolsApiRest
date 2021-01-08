using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class MetodoDePago
    {
        public MetodoDePago()
        {
            OrdenProducto = new HashSet<OrdenProducto>();
        }

        public int IdMetodoPago { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<OrdenProducto> OrdenProducto { get; set; }
    }
}
