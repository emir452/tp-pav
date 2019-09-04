using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistence
{
    interface IDao<T>
    {
        void add(T entiti);
        void update(T entiti);
        void delete(int id);
        List<T> selectAll();

    }
}
