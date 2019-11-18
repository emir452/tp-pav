using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

public void createHead()
        {
            List<string> header = new List<string>();
            header.Add("alumno");
            header.Add("tema");
            header.Add("nota");
            header.Add("fecha");
            header.Add("obserbaciones");
            report.addRow(header);
}
        public void createBodi()
{


}
        public void createFooter()
        {
}
        public IReport GetReport()
        {
            return report;
        }

            }
}
