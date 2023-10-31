using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamentoRepository
{
    private readonly FarmaciaAppContext _context;

    public DepartamentoRepository(FarmaciaAppContext context) : base(context)
    {
        _context = context;
    }
}