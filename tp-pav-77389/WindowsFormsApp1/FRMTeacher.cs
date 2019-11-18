using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domainEntities;
using visnes;
namespace  presentation
{
    public partial class FRMTeacher : Form
    {
        private TeacherActiviti teacherActiviti; 
        public FRMTeacher(TeacherActiviti teacherActiviti)
        {
            InitializeComponent();
            this.teacherActiviti = teacherActiviti;
        }
        private void  btnRegisterClass_click(object sender, EventArgs e)
        {


        }
    }
}
