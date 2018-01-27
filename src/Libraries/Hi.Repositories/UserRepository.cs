using Hi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
    }
}
