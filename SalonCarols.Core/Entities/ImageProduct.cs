using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class ImageProduct
    {
        public int? IdProductImage { get; set; }
        public int IdImage { get; set; }
        public string Image { get; set; }

        public virtual Product ProductImage { get; set; }
    }
}
