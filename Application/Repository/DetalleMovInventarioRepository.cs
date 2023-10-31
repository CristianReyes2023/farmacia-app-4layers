using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class DetalleMovInventarioRepository : GenericRepository<DetalleMovInventario>, IDetalleMovInventarioRepository
{
    private readonly FarmaciaAppContext _context;

    public DetalleMovInventarioRepository(FarmaciaAppContext context) : base(context)
    {
        _context = context;
    }
}