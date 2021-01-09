using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Employee
    {
        public Employee()
        {
            RolEmployee = new HashSet<RolEmployee>();
        }

        public int IdEmployee { get; set; }
        public string IdEmployeeAddress { get; set; }
        public int IdProvinceEmployee { get; set; }
        public int IdTelephoneNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentificationCard { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<RolEmployee> RolEmployee { get; set; }
    }
}
