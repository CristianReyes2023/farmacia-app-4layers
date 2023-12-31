using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class RefreshTokenRepository : GenericRepository<RefreshToken>, IRefreshTokenRepository
    {
        private readonly FarmaciaAppContext _context;

        public RefreshTokenRepository(FarmaciaAppContext context) : base(context)
        {
            _context = context;
        }
    }
}