using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Departamento : BaseEntity
{
    public int DepartanmentoId { get; set; }
    public string NombreDepartamento { get; set; }
    public Pais Paises { get; set; }
}
