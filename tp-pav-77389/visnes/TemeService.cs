using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domainEntities;
using persistence;
namespace visnes
{
    public  class TemeService
    {
        private ITemeDao persistenceTemes;
        public TemeService()
        {
            persistenceTemes = new TemeDao();
}
        public void RegisterTeme(Teme teme)
        {
            persistenceTemes.registerTeme(teme);
}
        public  Teme findById(int id)
        {
            return persistenceTemes.findById(id);
            


        }
    }
}
