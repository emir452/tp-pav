using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FRMlogin : Form
    {
        public FRMlogin()
        {
            InitializeComponent();
        }
private void btnInit_clik(object sender, EventArgs e)
        {

}
        private void btnExit_clik(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
 }
        private void FRMlogin_load(object sender,EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
