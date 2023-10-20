using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Proveedor : BaseEntity
{
    public int ProveedorId { get; set; }
    public string NombreProveedor { get; set; }   
    public TipoPersona TipoPersonas { get; set; }
    public Municipio Municipios { get; set; }
}
