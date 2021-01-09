using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Province
    {
        public Province()
        {
            Client = new HashSet<Client>();
            Provider = new HashSet<Provider>();
        }

        public int IdProvince { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Provider> Provider { get; set; }
    }
}
