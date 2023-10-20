using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Empleado : BaseEntity
{
    public int EmpleadoId { get; set; }
    public int IdEmp { get; set; }
    public string NombreEmpleado { get; set; }
    public Cargo Cargos { get; set; }
    public DateOnly FechaIngresoEmpleado { get; set; }
    public Municipio Municipios { get; set; }

}
