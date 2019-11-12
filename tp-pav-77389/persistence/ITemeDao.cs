using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;
namespace persistence
{
     public interface ITemeDao
    {
        void registerTeme(Teme teme);
        List<Teme> getAll();
        Teme findById(int id);


    }
}
