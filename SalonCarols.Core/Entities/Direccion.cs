using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Direccion
    {
        public Direccion()
        {
            OrdenProducto = new HashSet<OrdenProducto>();
            Proveedor = new HashSet<Proveedor>();
        }

        public int IdDireccion { get; set; }
        public string Calle { get; set; }
        public string Barrio { get; set; }
        public string Sector { get; set; }
        public string CodigoPostal { get; set; }

        public virtual ICollection<OrdenProducto> OrdenProducto { get; set; }
        public virtual ICollection<Proveedor> Proveedor { get; set; }
    }
}
