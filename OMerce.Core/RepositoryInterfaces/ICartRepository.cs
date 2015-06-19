using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Core.RepositoryInterfaces
{
    public interface ICartRepository
    {
        ShoppingCart GetById(int id);
        IEnumerable<ShoppingCart> GetAll();
        void Save(ShoppingCart cart);
    }
}
