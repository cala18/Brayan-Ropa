using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class FormaPago : BaseEntity
{
    public int FormaPagoId { get; set; }
    public string DescripcionFormaPago { get; set; }
}
