using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class RolEmpleado
    {
        public int IdRol { get; set; }
        public int? IdRolEmpleado { get; set; }
        public string Nombre { get; set; }

        public virtual Empleado IdRolEmpleadoNavigation { get; set; }
    }
}
