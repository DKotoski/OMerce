using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMerce.Core
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime DateCreated { get; private set; }
        public bool IsDeleted { get; set; }

        public BaseEntity()
        {
            DateCreated = DateTime.Now;
        }
    }
}
