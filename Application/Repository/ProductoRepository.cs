using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class ProductoRepository : GenericRepositoryString<Producto>, IProductoRepository
{
    private readonly FarmaciaAppContext _context;

    public ProductoRepository(FarmaciaAppContext context) : base(context)
    {
        _context = context;
    }
}
