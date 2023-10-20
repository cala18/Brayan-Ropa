using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICargo Cargos {get;}
        ICliente Clientes {get;}
        IColor Colores {get;}
        IDepartamento Departamentos {get;}
        IDetalleVenta DetalleVenta {get;}
        IEmpleado Empleados {get;}
        IEmpresa Empresas {get;}
        IEstado Estados {get;}
        IFormaPago FormaPagos {get;}
        IGenero Generos {get;}
        IInsumo Insumos {get;}
        IInsumoProveedor InsumoProveedores {get;}
        IInventario Inventarios {get;}
        IInventarioTalla InventarioTallas {get;}
        IMunicipio Municipios {get;}
        IOrden Ordens {get;}
        IPais Paises {get;}
        IPrenda Prendas {get;}
        IProveedor Proveedores {get;}
        ITalla Tallas {get;}
        ITipoEstado TipoEstados {get;}
        ITipoPersona TipoPersonas {get;}
        ITipoProteccion TipoProtecciones {get;}
        IVenta Ventas {get;} 

        Task<int> SaveAsync();
    }
}