using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Insumo : BaseEntity
{
    public int InsumoId { get; set; }
    public string NombreInsumo { get; set; }
    public double ValorUnitarioInsumo { get; set; }
    public int StockMinimo { get; set; }
    public int StockMaximo { get; set; }

}
