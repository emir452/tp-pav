using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reports
{
     public interface IReportBuilder
    {
         void createHead();
        void createBodi();
        void createFooter();
        IReport GetReport();
    }
}
