using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using domainEntities;
namespace entity_builder
{
     public  class TemeBuilder
    {
         
        public Teme parseTeme( DataRow row)
        {

            return row!=null? new Teme(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString()): throw new Exception();


}

    }
}
