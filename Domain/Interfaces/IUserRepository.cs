using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using iText.Commons.Bouncycastle.Asn1.X509;

namespace Domain.Interfaces;
public interface IUserRepository : IGenericRepository<User>
{

}
