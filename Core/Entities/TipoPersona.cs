using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class TipoPersona : BaseEntity
{
    public readonly object Cliente;

    public int TipoPersonaId { get; set; }
    public string NombreTipoPersona { get; set; }
}
