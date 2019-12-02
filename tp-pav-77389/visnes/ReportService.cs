using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reports;
namespace visnes
{
     public class ReportService
    {
        public IReport createSimpleStudentReport()
        {
            IReportBuilder reportBuilder = new SimpleStudentReportBuilder();
            reportBuilder.createHead();
            reportBuilder.createBodi();
            reportBuilder.createFooter();
            return reportBuilder.GetReport();
}
        public IReport createStudentTemeReport()
        {
            IReportBuilder reportBuilder = new StudentTemeReportBuilder();
            IReport report;
            reportBuilder.createHead();
            reportBuilder.createBodi();
            reportBuilder.createFooter();
            report = reportBuilder.GetReport();
            return report;
            

}
    }
}
