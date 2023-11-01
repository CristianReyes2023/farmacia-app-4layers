using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersonaRepository
{
    private readonly FarmaciaAppContext _context;

    public TipoPersonaRepository(FarmaciaAppContext context) : base(context)
    {
        _context = context;
    }
}
