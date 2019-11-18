using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reports
{
     public class Report : IReport 
    {
        public List<List<string>> bodiReport { get; }
        // el bodiReport reprecenta una lista de filas  
        public Report()
        {
            bodiReport = new List<List<string>>();
        }
        public void addRow(List<string> row)
        {
            bodiReport.Add(row);
        }
        public int cantRows()
        {
            return bodiReport.Count;
        }
        public int cantCols()
        {
            return bodiReport[0].Count;
        }


    }
}
