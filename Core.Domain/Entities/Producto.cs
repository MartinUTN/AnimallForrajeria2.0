using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    /// <summary>
    /// Representa un producto en el inventario.
    /// Es una entidad de dominio pura.
    /// </summary>
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string? CodigoBarras { get; set; }
    }
}