using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Empleado
    {
        public Empleado()
        {
            RolEmpleado = new HashSet<RolEmpleado>();
        }

        public int IdEmpleado { get; set; }
        public string IdDireccionEmpleado { get; set; }
        public int IdProvinciaEmpleado { get; set; }
        public int IdNumeroTelefonico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }

        public virtual ICollection<RolEmpleado> RolEmpleado { get; set; }
    }
}
