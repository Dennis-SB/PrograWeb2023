using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            Pedidos = new HashSet<Pedido>();
            Productos = new HashSet<Producto>();
        }

        public int CodProveedor { get; set; }
        public string NombreProveedor { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? CodigoArchivo { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
