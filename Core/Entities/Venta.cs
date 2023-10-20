using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Venta : BaseEntity
{
    public int VentaId { get; set; }
    public DateOnly FechaVenta { get; set; }
    public Empleado Empleados { get; set; }
    public Cliente Clientes { get; set; }
    public FormaPago FormaPagos { get; set; }
}
