using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Core.Interfaces;
public interface IUnitOfWork 
{
    ICiudadRepository Ciudades {get;}
    IContactoPersonaRepository ContactoPersonas {get;}
    IDepartamentoRepository Departamentos {get;}
    IDetalleMovInventarioRepository DetalleMovInventarios {get;}
    IFacturaRepository Facturas {get;}
    IFormaPagoRepository FormaPagos {get;}
    IInventarioRepository Inventarios {get;}
    IMarcaRepository Marcas {get;}
    IMovimientoInventarioRepository MovimientoInventarios {get;}
    IPaisRepository Paises {get;}
    IPersonaRepository Personas {get;}
    IPresentacionRepository Presentaciones {get;}
    IProductoRepository Productos {get;}
    IRolPersonaRepository RolPersonas {get;}
    ITipoContactoRepository TipoContactos {get;}
    ITipoDocumentoRepository TipoDocumentos {get;}
    ITipoMovInventarioRepository TipoMovInventarios {get;}
    ITipoPersonaRepository TipoPersonas {get;}
    IUbicacionPersonaRepository UbicacionPersonas {get;}
    IRefreshTokenRepository RefreshTokens {get;}
    IRolRepository Rols {get;}
    IUserRepository Users {get;}

    Task<int> SaveAsync();
}
