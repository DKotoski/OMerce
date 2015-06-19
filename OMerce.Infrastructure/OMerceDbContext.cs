using OMerce.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Infrastructure
{
    class OMerceDbContext:DbContext
    {
        public OMerceDbContext(string connectionString):base(connectionString)
        {

        }

        public DbSet<ShoppingCart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
