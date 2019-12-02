using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace util
{
     public interface Iterator<E>
    {
        Boolean hasNext();
        E next();
    }
}
