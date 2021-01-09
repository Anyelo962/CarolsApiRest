using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class Product
    {
        public Product()
        {
            ShoppingCart = new HashSet<ShoppingCard>();
            OrderDetail = new HashSet<OrderDetail>();
            ImageProducts = new HashSet<ImageProduct>();
        }

        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int? Amount { get; set; }
        public decimal? Total { get; set; }
        public int? IdProvider { get; set; }
        public int? IdCategoryP { get; set; }

        public virtual Category CategoryP { get; set; }
        public virtual Provider ProviderP { get; set; }
        public virtual ICollection<ShoppingCard> ShoppingCart { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<ImageProduct> ImageProducts { get; set; }
    }
}
