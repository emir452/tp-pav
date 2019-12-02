using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reports;
namespace visnes.Properties
{
     public class StudentsTemEReport : IReportBuilder
    {
        private IReport report; 
        public StudentsTemEReport()
        {
            report = new Report();
}
        public override void createHead()
{
            List<string> head = new List<string>();
            head.Add("alumno";
            head.Add("tema");
                report.addRow(head);
}
        public override void createBodi()
        {
            throw new NotImplementedException();()
                {

            }
        }
    }
}

