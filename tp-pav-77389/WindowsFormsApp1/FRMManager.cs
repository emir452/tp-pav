﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using visnes;
namespace     WindowsFormsApp1
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

}
        private void itemDeleteStudent_click(object sender, EventArgs e)
        {

        }
        private void itemRegisterTeacher_click(object sender, EventArgs e)
{
}
        private void itemModifiTeacher_click(object sender, EventArgs e)
{

}
        private void itemDeleteTeacher_Click(object sender, EventArgs e)
        {
        }

    }
}
