using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Provider
    {
        public Provider()
        {
            Product = new HashSet<Product>();
        }

        public int IdProvider { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public int? IdTelephone { get; set; }
        public int? IdProvince { get; set; }
        public int? IdAddress { get; set; }

        public virtual Addresss IdAddressN { get; set; }
        public virtual Province IdProvinceN { get; set; }
        public virtual Telephone IdTelephoneN { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
