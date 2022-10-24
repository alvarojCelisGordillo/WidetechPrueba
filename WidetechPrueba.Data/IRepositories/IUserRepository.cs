using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WidetechPrueba.Core;
using WidetechPrueba.Data.Entities;

namespace WidetechPrueba.Data.IRepositories
{
    public interface IUserRepository : IDataRepository<User>
    {
        User Get(string user);
    }
}