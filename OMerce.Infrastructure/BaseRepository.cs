using OMerce.Core;
using OMerce.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Infrastructure
{
    class BaseRepository<T>:IBaseRepository<T> where T:BaseEntity
    {
        private OMerceDbContext db;
        public BaseRepository()
        {
        }
        public BaseRepository(OMerceDbContext db)
        {
            this.db = db;
        }
        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>() as IEnumerable<T>;
        }

        public void Save(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }
    }
}
