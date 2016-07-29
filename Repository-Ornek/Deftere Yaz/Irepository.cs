using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Ornek
{
    public interface Irepository<T> where T : class
    {
        IEnumerable<T> List { get; }
        void ADD(T entity);
        void DELETE(T entity);
        void UPDATE(T entity);

    }
}
