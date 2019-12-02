using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using persistence;
using reports;

namespace visnes
{
     public class SimpleStudentReportBuilder : IReportBuilder
    {
        private IReport report; 
        public  SimpleStudentReportBuilder()
        {
            report = new Report();
        }

public override  void createHead()
        {
            List<string> header = new List<string>();
            header.Add("alumno");
            header.Add("tema");
            header.Add("nota");
            header.Add("fecha");
            header.Add("obserbaciones");
            report.addRow(header);
}
        public override void createBodi()
{
            foreach( DataRow i in new SimpleStudentReportQueri().createQueri().Rows)
            {
                report.addRow(toList(i));
}




}
        public override  void createFooter()
        {
}
        public override  IReport GetReport()
        {
            return report;
        }
        
            }
}
