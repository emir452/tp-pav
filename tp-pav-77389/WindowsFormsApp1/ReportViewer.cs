using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using util;
using reports;
namespace presentation
{
    public partial class ReportViewer : Form
    {
        private IReport report;
        public ReportViewer( IReport report)
        {
            InitializeComponent();
            this.report = report; 
        }
        public Control designReport()
        {
             TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.RowCount = report.cantRows();
            for (int i = 0; i < report.cantRows(); i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / report.cantRows()));
            }
            tlp.ColumnCount = report.cantCols();
            for (int i = 0; i < report.cantCols(); i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / report.cantCols()));
            }
            Label lblInformation = new Label();
            Iterator<List<string>> rowsIterator = report.iterator();
            for (int i = 0; i < report.cantRows(); i++)
            {
                List<string> row = rowsIterator.next();

                for (int j = 0; j < report.cantCols(); j++)
                {
                    lblInformation.Text = row[j];
                    tlp.Controls.Add(lblInformation, j, i);
                }
            }
            return tlp;

        }
    }
}
