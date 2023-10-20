using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Estado : BaseEntity
{
    public int EStadoId { get; set; }
    public string DescripcionEstado { get; set; }
    public TipoEstado TipoEstados { get; set; }

}
