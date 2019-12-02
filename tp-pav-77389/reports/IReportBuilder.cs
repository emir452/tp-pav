using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace reports
{
    public abstract class IReportBuilder
    {
        public abstract void createHead();
        public abstract void createBodi();
        public abstract void createFooter();
        public abstract IReport GetReport();

         public  List<string> toList(DataRow row)
        {
            List<string> result = new List<string>();
            foreach (Object i in row.ItemArray)
            {
                result.Add(i.ToString());
            }
            return result;
        }
    }
}
