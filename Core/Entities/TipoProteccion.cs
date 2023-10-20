using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class TipoProteccion : BaseEntity
{
    public int TipoProteccionId { get; set; }
    public string DescripcionTipoProteccion { get; set; }
}
