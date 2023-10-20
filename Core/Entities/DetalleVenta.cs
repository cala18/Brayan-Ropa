using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class DetalleVenta : BaseEntity
{
    public int DetalleVentaId { get; set; }
    public ICollection<Venta> Ventas { get; set; }
     public ICollection<Inventario> Inventarios { get; set; }
    public ICollection<Talla> Tallas { get; set; }
    public string Cantidad { get; set; }
    public double ValorUnitarioDetalle { get; set; }

}