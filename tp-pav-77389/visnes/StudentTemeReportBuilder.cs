using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using util;
using reports;
using persistence;
using System.Data;
namespace visnes
{
     public class StudentTemeReportBuilder : IReportBuilder
    {
        private IReport report;
        public StudentTemeReportBuilder()
        {
            report = new Report();

        }
        public override void createHead()
        {
            List<string> head = new List<string>();
            head.Add("alumno");
            head.Add("tema");
            report.addRow(head);
}
        public override void createBodi()
        {
foreach ( DataRow i in new StudentTemeReportQueri().createQueri().Rows)
            {
                report.addRow(toList(i));
}
}
        public override void createFooter()
{
}
        public override IReport GetReport()
        {
            return report;
        }
    }
}

