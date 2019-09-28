using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using visnes;
namespace WindowsFormsApp1
{
    public partial class FRMModifiStudent : Form
    {
        private ManagerActiviti managerActiviti;
         

        public FRMModifiStudent(ManagerActiviti managerActiviti)
        {
            InitializeComponent();
            this.managerActiviti = managerActiviti;
        }
    }
}
