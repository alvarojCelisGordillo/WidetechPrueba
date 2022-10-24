using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WidetechPrueba.Core;

namespace WidetechPrueba.Data
{
    public class WidetechPruebaDbContext : DbContext
    {
        public WidetechPruebaDbContext()
            : base("name=main")
        {
            Database.SetInitializer<WidetechPruebaDbContext>(null);
        }

        // Set the DbSet for the entities that will be used with data base.


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Ignore<IIdentifiableEntity>();

            // Create de model binding setup... ORM rules...
        }
    }
}