using OMerce.Core;
using OMerce.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Infrastructure
{
    public class CartRepository:ICartRepository
    {
        private OMerceDbContext db;
        public CartRepository()
        {
                
        }
        public CartRepository(OMerceDbContext dbcontext)
        {
            db = dbcontext;
        }
        public Core.ShoppingCart GetById(int id)
        {
            return db.Carts.Find(id);
        }

        public IEnumerable<Core.ShoppingCart> GetAll()
        {
            return db.Carts as IEnumerable<ShoppingCart>;
        }

        public void Save(Core.ShoppingCart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }
    }
}
