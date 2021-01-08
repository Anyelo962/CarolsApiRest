using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            CarritoCompras = new HashSet<CarritoCompras>();
            OrdenProducto = new HashSet<OrdenProducto>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
        public string Sexo { get; set; }
        public int? IdSmartPhone { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? IdProvincia { get; set; }

        public virtual Provincia IdProvinciaNavigation { get; set; }
        public virtual Telefono IdSmartPhoneNavigation { get; set; }
        public virtual ICollection<CarritoCompras> CarritoCompras { get; set; }
        public virtual ICollection<OrdenProducto> OrdenProducto { get; set; }
    }
}
