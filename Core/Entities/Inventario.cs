using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Inventario : BaseEntity
{
    public int InventarioId { get; set; }
    public int CodInventario { get; set; }
    public ICollection<Prenda> Prendas { get; set; }
    public double ValorVtaUsd { get; set; }
    
}
