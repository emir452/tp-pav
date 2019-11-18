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
namespace      presentation
{
    public partial class FRMManager : Form
    {
        private ManagerActiviti managerActiviti;
        public FRMManager(ManagerActiviti managerActiviti)
        {
            InitializeComponent();
            this.managerActiviti = managerActiviti;
        }
       private void  itemRegisterStudent_click(Object sender, EventArgs e)
        {
            new  FRMRegisterStudent(managerActiviti);
          
}
        private void itemModifiStudent_click(Object sender, EventArgs e)
        {
            new FRMModifiStudent(managerActiviti).ShowDialog();

}
        private void itemDeleteStudent_click(object sender, EventArgs e)
        {
            new FRMDeleteStudent(managerActiviti).ShowDialog();

        }
        private void itemRegisterTeacher_click(object sender, EventArgs e)
{
            new FRMRegisterTeacher(managerActiviti).ShowDialog();
}
        private void itemModifiTeacher_click(object sender, EventArgs e)
{
            

}
        private void itemDeleteTeacher_Click(object sender, EventArgs e)
        {
            new FRMDeleteTeacher( managerActiviti).ShowDialog();
        }
        private void itemRegisterTeme_click( object sender, EventArgs e)
        {
            new FRMRegisterTeme().ShowDialog();
}

    }
}
