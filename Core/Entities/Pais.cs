using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Pais : BaseEntity
{
    [Required]
    public int PaisId { get; set; }
    public string NombrePais { get; set; }

}
