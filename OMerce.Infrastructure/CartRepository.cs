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
        public Core.ShoppingCart GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Core.ShoppingCart> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Core.ShoppingCart cart)
        {
            throw new NotImplementedException();
        }
    }
}
