using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using util;
namespace reports
{
    public class Report : IReport
    {
         private List<List<string>> bodiReport;

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
    
    public Iterator<List<String>> iterator()
    {
            return new ReportRowsIterator(bodiReport);

    }
    private class ReportRowsIterator : Iterator<List<String>>
{

            private int current;
            private List<List<String>> rows;
            public ReportRowsIterator(List<List<String>> rows)
            {
                current = -1;
                this.rows = rows;
            }
            public Boolean hasNext()
            {
                return current < rows.Count;
}
            public List<String> next()
{
               if (hasNext())
                {
                    current++;
                    return rows[current];
}
                throw new Exception("no hay elemento siguiente");
            }
}
}
}

