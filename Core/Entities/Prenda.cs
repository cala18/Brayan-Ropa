using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Prenda : BaseEntity
{
    public int PrendaId{ get; set; }
    public int IdPrenda { get; set; }
    public string NombrePrenda { get; set; }
    public double ValorUnitarioPrendaCop { get; set; }
    public double ValorUnitarioPrendaUsd { get; set; }
    public Estado Estados { get; set; }
    public TipoProteccion TipoProtecciones { get; set; }
    public Genero Generos { get; set; }
    
}
