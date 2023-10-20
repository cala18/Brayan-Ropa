using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Departamento : BaseEntity
    {
        public string Nombre;
        public int IdPais;
        public Pais Pais;

        public ICollection<Municipio> Municipios { get; set; }
    }
}