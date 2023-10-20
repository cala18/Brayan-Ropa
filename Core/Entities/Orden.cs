using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Orden : BaseEntity
{
    public int OrdenId { get; set; }
    public DateOnly FechaOrden { get; set; }
    public Empleado Empleados { get; set; }
    public Cliente Clientes { get; set; }
    public Estado Estados { get; set; }
}
