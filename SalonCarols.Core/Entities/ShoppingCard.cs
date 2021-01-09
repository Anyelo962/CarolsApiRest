using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class ShoppingCard
    {
        public int IdCart { get; set; }
        public int IdProduct { get; set; }
        public int IdClient { get; set; }
        public int Amount { get; set; }
 
        public virtual Client client{ get; set; }
        public virtual Product Product { get; set; }
    }
}
