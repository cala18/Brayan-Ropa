using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class InsumoProveedor : BaseEntity
{
     public ICollection<Insumo> Insumos { get; set; }
     public ICollection<Proveedor> Proveedores { get; set; }
}
