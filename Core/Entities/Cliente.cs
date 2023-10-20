using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Cliente : BaseEntity
    {
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public TipoPersona TipoPersonas { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public Municipio Municipios { get; set; }

    }
