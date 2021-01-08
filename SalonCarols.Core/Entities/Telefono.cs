using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Telefono
    {
        public Telefono()
        {
            Cliente = new HashSet<Cliente>();
            Proveedor = new HashSet<Proveedor>();
        }

        public int IdTelefono { get; set; }
        public string NumeroTelefonico { get; set; }
        public string TelefonoCelular { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Proveedor> Proveedor { get; set; }
    }
}
