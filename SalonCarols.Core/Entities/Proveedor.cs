using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Producto = new HashSet<Producto>();
        }

        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
        public string Sexo { get; set; }
        public int? IdTelefono { get; set; }
        public int? IdProvincia { get; set; }
        public int? IdDireccion { get; set; }

        public virtual Direccion IdDireccionNavigation { get; set; }
        public virtual Provincia IdProvinciaNavigation { get; set; }
        public virtual Telefono IdTelefonoNavigation { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
