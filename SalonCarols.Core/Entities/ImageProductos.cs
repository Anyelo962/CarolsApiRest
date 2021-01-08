using System;
using System.Collections.Generic;

namespace SalonCarols.Core.entities
{
    public partial class ImageProductos
    {
        public int? IdProductoImagen { get; set; }
        public int IdImage { get; set; }
        public string Image { get; set; }

        public virtual Producto IdProductoImagenNavigation { get; set; }
    }
}
