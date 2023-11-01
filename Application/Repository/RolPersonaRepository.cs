using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class RolPersonaRepository : GenericRepository<RolPersona>, IRolPersonaRepository
{
    private readonly FarmaciaAppContext _context;

    public RolPersonaRepository(FarmaciaAppContext context) : base(context)
    {
        _context = context;
    }
}
