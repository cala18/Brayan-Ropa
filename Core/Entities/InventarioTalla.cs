using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class InventarioTalla : BaseEntity
{
    public ICollection<Inventario> Inventarios { get; set; }
    public ICollection<Talla> Tallas { get; set; }
}
