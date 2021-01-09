using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int IdProductOrder { get; set; }
        public int IdProductO { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public virtual OrderProduct OrdenProduct { get; set; }
        public virtual Product ProductO { get; set; }
    }
}
