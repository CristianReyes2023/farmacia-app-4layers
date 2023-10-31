using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;
public class ContactoPersonaRepository : GenericRepository<ContactoPersona>, IContactoPersonaRepository
{
    private readonly FarmaciaAppContext _context;

    public ContactoPersonaRepository(FarmaciaAppContext context) : base(context)
    {
        _context = context;
    }
}
