using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace util
{
     public interface Iterable<E>
    {
        Iterator<E> iterator();

    }
}
