using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int IdCategory { get; set; }
        public string NameProduct { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
