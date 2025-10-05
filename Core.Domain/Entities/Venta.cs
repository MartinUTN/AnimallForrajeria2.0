using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    /// <summary>
    /// Representa una transacción de venta.
    /// Contiene una colección de los productos vendidos.
    /// </summary>
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        // Propiedad de navegación: una venta tiene muchos detalles.
        public ICollection<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }
}