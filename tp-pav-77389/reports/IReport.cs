using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reports
{
     public interface IReport
    {
        int cantRows();
        int cantCols();
        void addRow(List<string> row);
    }
}
