using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class MovimientoInventarioRepository : GenericRepositoryString<MovimientoInventario>, IMovimientoInventarioRepository
{
    private readonly FarmaciaAppContext _context;

    public MovimientoInventarioRepository(FarmaciaAppContext context) : base(context)
    {
        _context = context;
    }
}
