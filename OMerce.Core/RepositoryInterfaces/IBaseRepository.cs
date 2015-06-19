using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Core.RepositoryInterfaces
{
    public interface IBaseRepository<T>
    {
            T GetById(int id);
            IEnumerable<T> GetAll();
            void Save(T item);
    }
}
