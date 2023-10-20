using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Cargo : BaseEntity
{
    public int CargoId { get; set; }
    public string DescripcionCargo { get; set; }
    public double SueldoBase { get; set; }
}
