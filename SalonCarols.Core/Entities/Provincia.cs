using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Provincia
    {
        public Provincia()
        {
            Cliente = new HashSet<Cliente>();
            Proveedor = new HashSet<Proveedor>();
        }

        public int IdProvincia { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Proveedor> Proveedor { get; set; }
    }
}
