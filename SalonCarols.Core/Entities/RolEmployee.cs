using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class RolEmployee
    {
        public int IdRol { get; set; }
        public int? IdRolEmployee { get; set; }
        public string Name { get; set; }

        public virtual Employee IdRolEmployeeN { get; set; }
    }
}
