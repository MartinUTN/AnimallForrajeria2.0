using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    /// <summary>
    /// Representa una línea individual dentro de una Venta.
    /// Conecta un Producto con una Venta y especifica la cantidad y el precio en ese momento.
    /// </summary>
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; } // Precio al momento de la venta

        // Claves foráneas para la relación
        public int VentaId { get; set; }
        public int ProductoId { get; set; }

        // Propiedades de navegación para EF Core
        public Venta? Venta { get; set; }
        public Producto? Producto { get; set; }
    }
}