using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Telephone
    {
        public Telephone()
        {
            Client = new HashSet<Client>();
            Provider = new HashSet<Provider>();
        }

        public int IdTelephone { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhone { get; set; }

        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Provider> Provider { get; set; }
    }
}
