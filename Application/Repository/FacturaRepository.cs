using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class FacturaRepository : GenericRepository<Factura>, IFacturaRepository
{
    private readonly FarmaciaAppContext _context;

    public FacturaRepository(FarmaciaAppContext context) : base(context)
    {
        _context = context;
    }
}
