using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using util;
namespace reports
{
     public interface IReport : Iterable<List<String>> 
    {
        int cantRows();
        int cantCols();
        void addRow(List<string> row);
    }
}
