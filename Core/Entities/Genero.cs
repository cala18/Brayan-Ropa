using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Genero : BaseEntity
{
    public int GeneroId { get; set; }
    public string DescripcionGenero { get; set; }
}
