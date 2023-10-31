using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class PaisRepository : GenericRepository<Pais>, IPaisRepository
{
    private readonly FarmaciaAppContext _context;

    public PaisRepository(FarmaciaAppContext context) : base(context)
    {
        _context = context;
    }
}
