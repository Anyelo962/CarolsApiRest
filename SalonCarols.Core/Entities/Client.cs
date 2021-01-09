using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Client
    {
        public Client()
        {
            ShoppingCart = new HashSet<ShoppingCard>();
            ProductOrder = new HashSet<OrderProduct>();
        }

        public int IdClient { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public int? IdSmartPhone { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? IdProvince { get; set; }

        public virtual Province Province { get; set; }
        public virtual Telephone SmartPhone { get; set; }
        public virtual ICollection<ShoppingCard> ShoppingCart { get; set; }
        public virtual ICollection<OrderProduct> ProductOrder { get; set; }
    }
}
