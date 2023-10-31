using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class RefreshRepository : GenericRepository<RefreshToken>, IRefreshTokenRepository
    {
        private readonly FarmaciaAppContext _context;

        public RefreshRepository(FarmaciaAppContext context) : base(context)
        {
            _context = context;
        }
    }
}