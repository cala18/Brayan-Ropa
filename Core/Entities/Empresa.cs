using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Empresa : BaseEntity
{
    public int EmpresaId { get; set; }
    public int Nit { get; set; }
    public string RazonSocial { get; set; }
    public string RepresentanteLegal { get; set; }
    public DateOnly FechaCreacion { get; set; }
    public Municipio Municipios { get; set; }
}
