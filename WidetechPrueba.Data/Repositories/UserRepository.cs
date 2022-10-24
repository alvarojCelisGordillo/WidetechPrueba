using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WidetechPrueba.Core;
using WidetechPrueba.Data.Entities;
using WidetechPrueba.Data.IRepositories;

namespace WidetechPrueba.Data.Repositories
{
    public class UserRepository : DataRepositoryBase<User, WidetechPruebaDbContext>, IUserRepository
    {
        public User Get(string user)
        {
            throw new NotImplementedException();
            // Db implementation to be defined here...
        }

        protected override DbSet<User> DbSet(WidetechPruebaDbContext entityContext)
        {
            throw new NotImplementedException();
            // Db implementation to be defined here...
        }

        protected override Expression<Func<User, bool>> IdentifierPredicate(WidetechPruebaDbContext entityContext, int id)
        {
            throw new NotImplementedException();
            // Db implementation to be defined here...
        }
    }
}